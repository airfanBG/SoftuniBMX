namespace BicycleApp.Services.Services.IdentityServices
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.IdentityModels;

    using Microsoft.AspNetCore.Identity;
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

        public ClientService(UserManager<Client> userManager, SignInManager<Client> signInManager, BicycleAppDbContext dbContext, IConfiguration configuration, IModelsFactory modelFactory)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dbContext = dbContext;
            this.configuration = configuration;
            this.modelFactory = modelFactory;
        }

        /// <summary>
        /// This method cleates a new client entry in the database
        /// </summary>
        /// <param name="clientDto">Dto with information abouth the client</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">If the dto is null</exception>
        /// <exception cref="ArgumentException">If the email is already registered</exception>
        public async Task<bool> RegisterClientAsync(ClientRegisterDto clientDto)
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
            await userManager.AddToRoleAsync(client, clientDto.Role);

            if (result == null)
            {
                return false;
            }

            if (result.Succeeded)
            {
                return true;
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
            var roles =await userManager.GetRolesAsync(client);
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
    }
}
