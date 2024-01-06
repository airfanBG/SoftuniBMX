namespace BicycleApp.Services.Services.IdentityServices
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.IdentityModels;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.WebUtilities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;

    using static BicycleApp.Common.UserConstants;

    public class ClientService : IClientService
    {
        private readonly UserManager<BaseUser> userManager;
        private readonly SignInManager<BaseUser> signInManager;
        private readonly RoleManager<BaseUserRole> roleManager;
        private readonly BicycleAppDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly IModelsFactory modelFactory;
        private readonly IEmailSender emailSender;
        private readonly IStringManipulator stringManipulator;
        private readonly IOptionProvider optionProvider;
        private readonly IDateTimeProvider dateTimeProvider;
        private readonly IImageStore imageStore;

        public ClientService(UserManager<BaseUser> userManager,
                             SignInManager<BaseUser> signInManager,
                             RoleManager<BaseUserRole> roleManager,
                             BicycleAppDbContext dbContext,
                             IConfiguration configuration,
                             IModelsFactory modelFactory,
                             IEmailSender emailSender,
                             IStringManipulator stringManipulator,
                             IOptionProvider optionProvider,
                             IDateTimeProvider dateTimeProvider,
                             IImageStore imageStore)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.dbContext = dbContext;
            this.configuration = configuration;
            this.modelFactory = modelFactory;
            this.emailSender = emailSender;
            this.stringManipulator = stringManipulator;
            this.optionProvider = optionProvider;
            this.dateTimeProvider = dateTimeProvider;
            this.imageStore = imageStore;
        }

        /// <summary>
        /// This method cleates a new client entry in the database
        /// </summary>
        /// <param name="clientDto">Dto with information abouth the client</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">If the dto is null</exception>
        /// <exception cref="ArgumentException">If the email is already registered</exception>
        public async Task<bool> RegisterClientAsync(ClientRegisterDto clientDto, string httpScheme, string httpHost)
        {
            if (clientDto == null)
            {
                throw new ArgumentNullException(nameof(clientDto));
            }

            var existingClient = await userManager.FindByEmailAsync(clientDto.Email);
            if (existingClient != null)
            {
                throw new ArgumentException($"Client with email: {clientDto.Email} already exists!");
            }

            Client client = this.modelFactory.CreateNewClientModel(clientDto);
            var townId = await this.GetTownIdAsync(clientDto.Town);
            client.TownId = townId;
            client.DelivaryAddress.TownId = townId;
            var result = await this.userManager.CreateAsync(client, clientDto.Password);

            //TODO: Remove client role management. DB don`t need so much records.
            var isRoleExists = await roleManager.RoleExistsAsync(clientDto.Role.ToLower());
            var identityRole = new BaseUserRole();
            identityRole.Name = clientDto.Role;
            if (!isRoleExists)
            {
                await roleManager.CreateAsync(identityRole);
            }
            var roleName = await roleManager.GetRoleNameAsync(identityRole);
            await userManager.AddToRoleAsync(client, roleName);

            if (result == null)
            {
                return false;
            }

            if (result.Succeeded)
            {
                var confirmationToken = await userManager.GenerateEmailConfirmationTokenAsync(client);
                confirmationToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(confirmationToken));
                var endPointToComfirmEmail = optionProvider.ClientEmailConfirmEnpoint();
                var routeValues = $"userId={client.Id}&code={confirmationToken}";
                var callback = stringManipulator.UrlMaker(httpScheme, httpHost, endPointToComfirmEmail, routeValues);
                var emailSenderResult = emailSender.IsSendedEmailForVerification(clientDto.Email, $"{clientDto.FirstName} {clientDto.LastName}", callback);
                if (emailSenderResult)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method sing in the client
        /// </summary>
        /// <param name="clientDto">Information for the client to be sign in</param>
        /// <returns>A responce and dto with info for the client</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<ClientReturnDto> LoginClientAsync(ClientLoginDto clientDto)
        {
            if (clientDto == null)
            {
                throw new ArgumentNullException(nameof(clientDto));
            }

            var client = await this.userManager.FindByEmailAsync(clientDto.Email);

            if (client == null)
            {
                return new ClientReturnDto() { Result = false };
            }

            var passwordMatches = await this.userManager.CheckPasswordAsync(client, clientDto.Password);

            if (!passwordMatches)
            {
                return new ClientReturnDto() { Result = false };
            }

            var result = await signInManager.CheckPasswordSignInAsync(client, clientDto.Password, false);

            if (result.Succeeded)
            {
                var user = await dbContext.Clients
                                          .Include(o => o.Orders)
                                          .FirstOrDefaultAsync(b => b.Id == client.Id);

                var roles = await userManager.GetRolesAsync(client);
                var userRole = roles[0];
                return new ClientReturnDto()
                {
                    ClientId = client.Id,
                    ClientFullName = $"{client.FirstName} {client.LastName}",
                    Role = userRole,
                    Token = await this.GenerateJwtTokenAsync(client),
                    Balance = user.Balance,
                    Image = await imageStore.GetUserImage(client.Id, userRole),
                    Result = true,
                    IsAnyOrderReady = user.Orders.Any(o => o.DateFinish != null && o.DateSended == null && o.ClientId == client.Id)
                };
            }
            else
            {
                return new ClientReturnDto { Result = false };
            }
        }

        /// <summary>
        /// Returns information abouth the client
        /// </summary>
        /// <param name="Id">The id of the client</param>
        /// <returns>Dto with information for the client</returns>
        public async Task<ClientEditDto?> GetClientInfoAsync(string Id)
        {
            var client = await dbContext.Clients.Include(da => da.DelivaryAddress).FirstOrDefaultAsync(c => c.Id == Id);

            if (client == null)
            {
                return null;
            }

            string? town = await dbContext.Towns
                .Where(t => t.Id == client.TownId)
                .Select(t => t.Name)
                .FirstOrDefaultAsync();

            return new ClientEditDto()
            {
                ClientId = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,                
                Balance= client.Balance,
                IBAN = client.IBAN,
                PhoneNumber = client.PhoneNumber,
                Town = town,
                DelivaryAddress = new ClientAddressDto()
                {
                    Street = client.DelivaryAddress.Street,
                    StrNumber = client.DelivaryAddress.StrNumber,
                    Apartment = client.DelivaryAddress.Apartment,
                    Block = client.DelivaryAddress.Block,
                    Country = client.DelivaryAddress.Country,
                    District = client.DelivaryAddress.District,
                    Floor = client.DelivaryAddress.Floor,
                    PostCode = client.DelivaryAddress.PostCode
                },
            };
        }

        /// <summary>
        /// This methos changes the password for a client in the database
        /// </summary>
        /// <param name="clientPasswordChangeDto">Input data</param>
        /// <returns>True/False</returns>
        /// <exception cref="ArgumentNullException">If input data is null throws exception</exception>
        public async Task<bool> ChangeClientPasswordAsync(ClientPasswordChangeDto clientPasswordChangeDto)
        {
            if (clientPasswordChangeDto == null)
            {
                throw new ArgumentNullException(nameof(clientPasswordChangeDto));
            }

            var client = await userManager.FindByIdAsync(clientPasswordChangeDto.ClentId);

            if (client == null)
            {
                // Client not found
                return false;
            }

            var result = await userManager.ChangePasswordAsync(client, clientPasswordChangeDto.OldPassword, clientPasswordChangeDto.NewPasword);

            if (result.Succeeded)
            {
                // Password changed successfully
                return true;
            }
            else
            {
                // Failed to change password
                return false;
            }
        }

        /// <summary>
        /// Client confirm the email
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="token"></param>
        /// <returns>Task</returns>
        /// <exception cref="Exception"></exception>
        public async Task ConfirmEmailAsync(string clientId, string code)
        {
            try
            {
                var user = await dbContext.Clients.FirstAsync(u => u.Id == clientId);
                code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));

                await userManager.ConfirmEmailAsync(user, code);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        /// <summary>
        /// This methos creates a Jwt token
        /// </summary>
        /// <param name="client">The client model</param>
        /// <returns>Jwt token as string</returns>
        private async Task<string> GenerateJwtTokenAsync(BaseUser client)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, client.Id.ToString()),
                new Claim(ClaimTypes.Email, client.Email)
            };
            var roles = await userManager.GetRolesAsync(client);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var expires = DateTime.UtcNow.AddDays(7);

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecret"]));

            var credentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: configuration["JwtIssuer"],
                audience: configuration["JwtAudience"],
                claims: claims,
                expires: expires,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        /// <summary>
        /// This method returns the id of the specified town by it's name and creates in the the database if it is not preasant
        /// </summary>
        /// <param name="town">The name of the town</param>
        /// <returns>Id as Integer</returns>
        private async Task<int> GetTownIdAsync(string town)
        {
            var townEntity = await dbContext.Towns
                .Where(t => t.Name == town)
                .FirstOrDefaultAsync();

            if (townEntity == null)
            {
                var newTown = this.modelFactory.CreateNewTown(town);

                await dbContext.Towns.AddAsync(newTown);
                await dbContext.SaveChangesAsync();

                int id = await dbContext.Towns
                    .Where(t => t.Name == town)
                    .Select(t => t.Id)
                    .FirstOrDefaultAsync();

                return id;
            }
            else
            {
                return townEntity.Id;
            }
        }

        /// <summary>
        /// This method returns the bank details for the client
        /// </summary>
        /// <param name="clientId">The id of the client</param>
        /// <returns>Dto</returns>
        /// <exception cref="NullReferenceException">If invalid data ocurs</exception>
        public async Task<ClientBankDto> GetClientBankInfoAsync(string clientId)
        {
            if (string.IsNullOrWhiteSpace(clientId))
            {
                throw new ArgumentNullException(nameof(clientId));
            }

            Client? client = await dbContext.Clients
                .FirstOrDefaultAsync(c => c.Id == clientId);

            if (client == null)
            {
                throw new NullReferenceException(nameof(client));
            }

            return new ClientBankDto()
            {
                Id = client.Id,
                Balance = client.Balance,
                IBAN = client.IBAN
            };
        }


        /// <summary>
        /// This method updates the Iban and balance of a client
        /// </summary>
        /// <param name="clientBankDto">Input info</param>
        /// <returns>Dto</returns>
        /// <exception cref="ArgumentNullException">If input info is invalid throws</exception>
        public async Task<bool> UpdateClientBankInfoAsync(ClientBankDto clientBankDto)
        {
            if (clientBankDto == null)
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrWhiteSpace(clientBankDto.Id))
            {
                throw new ArgumentNullException();
            }

            Client? client = await dbContext.Clients
                .FirstOrDefaultAsync(c => c.Id == clientBankDto.Id);

            if (client == null)
            {
                return false;
            }

            client.IBAN = clientBankDto.IBAN;
            client.Balance += clientBankDto.Balance;

            await dbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// This method changes the password of a client
        /// </summary>
        /// <param name="clientLoginDto">Client info</param>
        /// <returns>Bool</returns>
        /// <exception cref="ArgumentNullException">If info is invalid</exception>
        public async Task<bool> ChangePassword(ClientLoginDto clientLoginDto)
        {
            if (clientLoginDto == null)
            {
                throw new ArgumentNullException(nameof(clientLoginDto));
            }

            var client = await userManager.FindByEmailAsync(clientLoginDto.Email);

            if (client == null)
            {
                return false;
            }

            var result = await userManager.RemovePasswordAsync(client);

            if (!result.Succeeded)
            {
                return false;
            }

            result = await userManager.AddPasswordAsync(client, clientLoginDto.Password);

            if (!result.Succeeded)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Reset forrgoten password.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Task<bool></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<bool> ResetPasswordToDefault(string email)
        {
            try
            {
                var client = await dbContext.Clients.FirstAsync(c => c.Email == email);
                //var roles = await userManager.GetRolesAsync(client);
                //string roleName = roles.First(r => r == CLIENT);

                var result = await emailSender.ResetUserPasswordWhenForrgotenAsync(client.Id, CLIENT);

                if (result)
                {
                    return true;
                }
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();
            }
            catch (Exception)
            {
            }
            return false;
        }

        public async Task<string> EditClientInfoAsync(ClientEditDto clientEditDto)
        {
            try
            {
                var client = await dbContext.Clients.Include(da => da.DelivaryAddress).FirstAsync(c => c.Id == clientEditDto.ClientId);

                var updatedTownId = await GetTownIdAsync(clientEditDto.Town);

                client.FirstName = clientEditDto.FirstName;
                client.LastName = clientEditDto.LastName;
                client.PhoneNumber = clientEditDto.PhoneNumber;
                client.TownId = updatedTownId;
                client.DateUpdated = dateTimeProvider.Now;

                var address = await dbContext.DelivaryAddresses.FirstAsync(da => da.Id == client.DelivaryAddressId);
                address.Floor = clientEditDto.DelivaryAddress.Floor;
                address.Street = clientEditDto.DelivaryAddress.Street;
                address.StrNumber = clientEditDto.DelivaryAddress.StrNumber;
                address.Apartment = clientEditDto.DelivaryAddress.Apartment;
                address.Block = clientEditDto.DelivaryAddress.Block;
                address.Country = clientEditDto.DelivaryAddress.Country;
                address.District = clientEditDto.DelivaryAddress.District;
                address.PostCode = clientEditDto.DelivaryAddress.PostCode;
                address.TownId = updatedTownId;

                await dbContext.SaveChangesAsync();

                return client.Id;
            }
            catch (Exception)
            {
            }

            return string.Empty;
        }
    }
}
