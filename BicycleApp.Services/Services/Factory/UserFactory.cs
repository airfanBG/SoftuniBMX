namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts.Factory;
    using Microsoft.EntityFrameworkCore;
    using static BicycleApp.Common.UserConstants;

    public class UserFactory : IUserFactory
    {
        private readonly BicycleAppDbContext _db;

        public UserFactory(BicycleAppDbContext db)
        {
            _db = db;
        }

        public async Task<BaseUser?> GetUserAsync(string userId, string userRole)
        {
            BaseUser? user = null;

            if (userRole.ToLower() != CLIENT)
            {
                user = await _db.Employees.FirstOrDefaultAsync(u => u.Id == userId);
            }
            else
            {
                user = await _db.Clients.FirstOrDefaultAsync(u => u.Id == userId);
            }

            return user;
        }
       

    }
}
