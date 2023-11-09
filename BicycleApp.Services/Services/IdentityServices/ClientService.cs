namespace BicycleApp.Services.Services.IdentityServices
{
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
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

        public ClientService(UserManager<Client> userManager, SignInManager<Client> signInManager, BicycleAppDbContext dbContext, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public async Task<bool> RegisterClientAsync(ClientRegisterDto clientDto)
        {
            if (clientDto == null)
            {
                throw new ArgumentNullException(nameof(clientDto));
            }

            var existingClient = await userManager.FindByEmailAsync(clientDto.Email);
            if (existingClient != null)
            {
                throw new ArgumentException($"Cliennt with email: {clientDto.Email} already exists!");
            }

            var client = new Client()
            {
                FirstName = clientDto.FirstName,
                LastName = clientDto.LastName,
                Email = clientDto.Email,
                NormalizedEmail = clientDto.Email.ToUpper(),
                UserName = clientDto.Email,
                NormalizedUserName = clientDto.Email.ToUpper(),
                PhoneNumber = clientDto.PhoneNumber,
                DelivaryAddress = clientDto.DelivaryAddress,
                TownId = await this.GetTownIdAsync(clientDto.Town),
                IBAN = clientDto.IBAN,
                Balance = clientDto.Balance,
                DateCreated = DateTime.UtcNow,
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false
            };

            var result = await this.userManager.CreateAsync(client, clientDto.Password);

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
                return new ClientReturnDto()
                {
                    ClientId = client.Id,
                    Token = this.GenerateJwtTokenAsync(client),
                    Result = true
                };
            }
            else
            {
                return new ClientReturnDto { Result = false };
            }


        }

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

        private string GenerateJwtTokenAsync(Client client)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, client.Id.ToString()),
                new Claim(ClaimTypes.Email, client.Email)
            };

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

        private async Task<int> GetTownIdAsync(string town)
        {
            var townEntity = await dbContext.Towns
                .Where(t => t.Name == town)
                .FirstOrDefaultAsync();

            if (townEntity == null)
            {
                var newTown = new Town()
                {
                    Name = town,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = null,
                    DateDeleted = null,
                    IsDeleted = false
                };

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
