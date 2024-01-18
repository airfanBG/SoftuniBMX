namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Data;
    using BicycleApp.Data.Interfaces;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using Microsoft.EntityFrameworkCore;
    using static BicycleApp.Common.Constants.UserConstants;

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
                return await _db.ImagesEmployees.AnyAsync(ie => ie.UserId == userId);
            }
            else
            {
                return await _db.ImagesClients.AnyAsync(ie => ie.UserId == userId);
            }
        }
        public async Task<IUserImage?> CreateUserImage(string userId, string userRole, string filePath, string imageName)
        {
            if (!string.IsNullOrEmpty(userId)
                && !string.IsNullOrEmpty(userRole)
                && !string.IsNullOrEmpty(filePath)
                && !string.IsNullOrEmpty(imageName))
            {
                try
                {
                    IUserImage userImage;

                    if (userRole.ToLower() != CLIENT)
                    {
                        userImage = new ImageEmployee()
                        {
                            UserId = userId,
                            ImageName = imageName,
                            ImageUrl = filePath
                        };
                    }
                    else
                    {
                        userImage = new ImageClient()
                        {
                            UserId = userId,
                            ImageName = imageName,
                            ImageUrl = filePath
                        };
                    }
                    return userImage;
                }
                catch (Exception)
                {
                }
            }
            return null;
        }
        public async Task<string?> GetUserImagePathAsync(string userId, string userRole)
        {
            try
            {
                string filePath = string.Empty;     
                if (userRole.ToLower() != CLIENT)
                {
                    var imageEmployee = await _db.ImagesEmployees.FirstAsync(ie => ie.UserId == userId);
                    filePath = imageEmployee.ImageUrl;
                }
                else
                {
                    var imageClient = await _db.ImagesClients.FirstAsync(ie => ie.UserId == userId);
                    filePath = imageClient.ImageUrl;
                }

                return filePath;
            }
            catch (Exception)
            {
            }
            return null;
        }
        public async Task<IUserImage?> UpdateUserImage(string userId, string userRole, string filePath, string imageName)
        {
            if (!string.IsNullOrEmpty(userId)
                && !string.IsNullOrEmpty(userRole)
                && !string.IsNullOrEmpty(filePath))
            {
                try
                {
                    IUserImage userUpdatedImage;

                    if (userRole.ToLower() != CLIENT)
                    {
                         userUpdatedImage = await _db.ImagesEmployees.FirstOrDefaultAsync(ie => ie.UserId == userId);

                        if (userUpdatedImage != null)
                        {
                            userUpdatedImage.ImageName = imageName;
                            userUpdatedImage.ImageUrl = filePath;
                        }
                    }
                    else
                    {
                         userUpdatedImage = await _db.ImagesClients.FirstOrDefaultAsync(ie => ie.UserId == userId);

                        if (userUpdatedImage != null)
                        {
                            userUpdatedImage.ImageName = imageName;
                            userUpdatedImage.ImageUrl = filePath;
                        }
                    }

                    return userUpdatedImage;
                }
                catch (Exception)
                {
                }
            }
            return null;
        }
    }
}
