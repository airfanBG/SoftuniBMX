namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using Microsoft.EntityFrameworkCore;
    using static BicycleApp.Common.UserConstants;

    public class UserImageFactory : IUserImageFactory
    {
        private readonly BicycleAppDbContext _db;
        public UserImageFactory(BicycleAppDbContext db)
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

        public async Task<string?> GetUserImagePathAsync(string userId, string userRole)
        {
            string filePath = string.Empty;

            if (userRole.ToLower() != CLIENT)
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
