namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using Microsoft.EntityFrameworkCore;
    using static BicycleApp.Common.UserConstants;

    public class Factory : IFactory
    {
        private readonly BicycleAppDbContext _db;

        public Factory(BicycleAppDbContext db)
        {
            _db = db;
        }

        public async Task<bool> CheckForExistingUserImage(string userId, string userRole)
        {
            if (userRole.ToLower() != CLIENT)
            {
                 return await _db.ImagesEmployees.AnyAsync(ie => ie.EmployeeId == userId);
            }
            else
            {
                return await _db.ImagesClients.AnyAsync(ie => ie.ClientId == userId);
            }
        }

        public async Task<bool> CreateUserImage(string userId, string userRole, string filePath, string imageName)
        {
            if (!string.IsNullOrEmpty(userId)
                && !string.IsNullOrEmpty(userRole)
                && !string.IsNullOrEmpty(filePath)
                && !string.IsNullOrEmpty(imageName))
            {
                try
                {
                    if (userRole.ToLower() != CLIENT)
                    {
                        ImageEmployee ie = new ImageEmployee()
                        {
                            EmployeeId = userId,
                            ImageName = imageName,
                            ImageUrl = filePath
                        };

                        await _db.ImagesEmployees.AddAsync(ie);
                    }
                    else
                    {
                        ImageClient ic = new ImageClient()
                        {
                            ClientId = userId,
                            ImageName = imageName,
                            ImageUrl = filePath
                        };

                        await _db.ImagesClients.AddAsync(ic);
                    }

                    await _db.SaveChangesAsync();

                    return true;
                }
                catch (Exception)
                {
                }
            }
            return false;
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

        public async Task<string?> GetUserImagePathAsync(string userId, string userRole)
        {
            string filePath = string.Empty;

            if(userRole.ToLower() != CLIENT)
            {
                var imageEmployee = await _db.ImagesEmployees.FirstOrDefaultAsync(ie => ie.EmployeeId == userId);
                filePath = imageEmployee.ImageUrl;
            }
            else
            {
                var imageClient = await _db.ImagesClients.FirstOrDefaultAsync(ie => ie.ClientId == userId);
                filePath = imageClient.ImageUrl;
            }

            return filePath;
        }

        public async Task<bool> UpdateUserImage(string userId, string userRole, string filePath)
        {
            try
            {
                if (userRole.ToLower() != CLIENT)
                {
                    var imageEmployee = await _db.ImagesEmployees.FirstOrDefaultAsync(ie => ie.EmployeeId == userId);

                    if (imageEmployee != null)
                    {
                        imageEmployee.ImageUrl = filePath;

                        _db.ImagesEmployees.Update(imageEmployee);
                    }                   
                }
                else
                {
                    var imageClient = await _db.ImagesClients.FirstOrDefaultAsync(ie => ie.ClientId == userId);

                    if (imageClient != null)
                    {
                        imageClient.ImageUrl = filePath;

                        _db.ImagesClients.Update(imageClient);
                    }
                }

                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

    }
}
