namespace BicycleApp.Services.Services.IdentityServices
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.IdentityModels;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class ClientService : IClientService
    {
        private readonly UserManager<Client> userManager;
        private readonly BicycleAppDbContext dbContext;

        public ClientService(UserManager<Client> userManager, BicycleAppDbContext dbContext)
        {
            this.userManager = userManager;
            this.dbContext = dbContext;
        }

        public async Task<bool> RegisterClient(ClientRegisterDto clientDto)
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
                TownId = await this.GetTownId(clientDto.Town),
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

        public async Task<bool> LoginClient(ClientLoginDto clientDto)
        {
            if (clientDto == null)
            {
                throw new ArgumentNullException(nameof(clientDto));
            }

            var client = await this.userManager.FindByEmailAsync(clientDto.Email);

            if (client == null)
            {
                return false;
            }

            var passwordMatches = await this.userManager.CheckPasswordAsync(client, clientDto.Password);
            if (!passwordMatches)
            {
                return false;
            }

            return true;
        }


        private async Task<int> GetTownId(string town)
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
