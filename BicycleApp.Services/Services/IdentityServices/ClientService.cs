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

    public class ClientService : IClientService
    {
        private readonly UserManager<Client> userManager;
        private readonly SignInManager<Client> signInManager;
        private readonly BicycleAppDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly IModelsFactory modelFactory;
        private readonly IEmailSender emailSender;
        private readonly IStringManipulator stringManipulator;
        private readonly IOptionProvider optionProvider;

        public ClientService(UserManager<Client> userManager, SignInManager<Client> signInManager, BicycleAppDbContext dbContext, IConfiguration configuration, IModelsFactory modelFactory, IEmailSender emailSender, IStringManipulator stringManipulator, IOptionProvider optionProvider)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dbContext = dbContext;
            this.configuration = configuration;
            this.modelFactory = modelFactory;
            this.emailSender = emailSender;
            this.stringManipulator = stringManipulator;
            this.optionProvider = optionProvider;
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
            client.TownId = await this.GetTownIdAsync(clientDto.Town);
            var result = await this.userManager.CreateAsync(client, clientDto.Password);
            //await userManager.AddToRoleAsync(client, clientDto.Role);

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

            var result = await signInManager.PasswordSignInAsync(clientDto.Email, clientDto.Password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var roles = await userManager.GetRolesAsync(client);
                return new ClientReturnDto()
                {
                    ClientId = client.Id,
                    ClientFullName = $"{client.FirstName} {client.LastName}",
                    Role = roles[0],
                    Token = await this.GenerateJwtTokenAsync(client),
                    Result = true
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
        public async Task<ClientInfoDto?> GetClientInfoAsync(string Id)
        {
            var client = await userManager.FindByIdAsync(Id);

            if (client == null)
            {
                return null;
            }

            string? town = await dbContext.Towns
                .Where(t => t.Id == client.TownId)
                .Select(t => t.Name)
                .FirstOrDefaultAsync();

            return new ClientInfoDto()
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                DelivaryAddress = client.DelivaryAddress,
                Balance = client.Balance,
                IBAN = client.IBAN,
                PhoneNumber = client.PhoneNumber,
                Town = town
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
        private async Task<string> GenerateJwtTokenAsync(Client client)
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

            Client? client = await userManager.FindByEmailAsync(clientLoginDto.Email);

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
    }
}
