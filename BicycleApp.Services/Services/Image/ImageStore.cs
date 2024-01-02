namespace BicycleApp.Services.Services.Image
{
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Image;
    using static BicycleApp.Common.UserConstants;

    using Microsoft.AspNetCore.Http;

    using System.Text;
    using System.Threading.Tasks;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.HelperClasses.Contracts;

    public class ImageStore : IImageStore
    {
        private readonly BicycleAppDbContext _db;
        private readonly IUserImageFactory _userImageFactory;
        private readonly IStringManipulator _stringManipulator;

        public ImageStore(
            BicycleAppDbContext db,
            IUserImageFactory userImageFactory,
            IStringManipulator stringManipulator)
        {
            _db = db;
            _userImageFactory = userImageFactory;
            _stringManipulator = stringManipulator;
        }

        /// <summary>
        /// Return users image as byte[].
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userRole"></param>
        /// <returns>string</returns>
        public async Task<string?> GetUserImage(string userId, string userRole)
        {
            try
            {
                var userPath = await _userImageFactory.GetUserImagePathAsync(userId, userRole);

                if (string.IsNullOrEmpty(userPath))
                {
                    return null;
                }

                var currentDirectory = Directory.GetCurrentDirectory();
                var fullPath = Path.Combine(currentDirectory, userPath);

                return fullPath;
            }
            catch (Exception)
            {
            }
            return null;
        }

        /// <summary>
        /// Add user`s image. If there is existing image - overrider it.
        /// </summary>
        /// <param name="userImageDto"></param>
        /// <returns>bool</returns>        
        public async Task<bool> IsAddedOrReplacedUserImage(UserImageDto userImageDto)
        {
            try
            {
                var userPath = GetRelativePathToUser(userImageDto.Role, userImageDto.Id);

                string[] allowedExtensions = { "jpg", "jpeg", "png", "gif", "pdf" };

                if (userImageDto.ImageToSave != null && userImageDto.ImageToSave.Length > 0)
                {
                    string imageExtension = userImageDto.ImageToSave.ContentType.Split("/").Last().ToLower();

                    if (allowedExtensions.Contains(imageExtension))
                    {
                        string fileName = await _stringManipulator.CreateGuid();
                        string filePath = Path.Combine(userPath, $"{fileName}.{imageExtension}");

                        bool isUserImageExist = await _userImageFactory.CheckForExistingUserImage(userImageDto.Id, userImageDto.Role);

                        if (isUserImageExist)
                        {
                            var updatedImage = await _userImageFactory.UpdateUserImage(userImageDto.Id, userImageDto.Role, filePath);

                            if (updatedImage == null)
                            {
                                return false;
                            }
                            if (userImageDto.Role.ToLower() != CLIENT)
                            {
                                 _db.ImagesEmployees.Update((ImageEmployee)updatedImage);
                            }
                            else
                            {
                                 _db.ImagesClients.Update((ImageClient)updatedImage);
                            }
                        }
                        else
                        {
                            var createdUserImage = await _userImageFactory.CreateUserImage(userImageDto.Id, userImageDto.Role, filePath, fileName);

                            if (createdUserImage == null)
                            {
                                return false;
                            }

                            if (userImageDto.Role.ToLower() != CLIENT)
                            {
                                await _db.ImagesEmployees.AddAsync((ImageEmployee)createdUserImage);
                            }
                            else
                            {
                                await _db.ImagesClients.AddAsync((ImageClient)createdUserImage);
                            }
                        }

                        await _db.SaveChangesAsync();
                        AddImage(userPath, filePath, userImageDto.ImageToSave);

                        return true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return false;
        }

        /// <summary>
        /// Return user path in file system. If there is no path - creates new one.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="userId"></param>
        /// <returns>string</returns>
        private string GetRelativePathToUser(string role, string userId)
        {
            var relativePath = new StringBuilder("wwwroot\\files\\profiles");

            relativePath.Append($"\\{role}");
            relativePath.Append($"\\{DateTime.UtcNow.Year}");
            relativePath.Append($"\\{DateTime.UtcNow.Month}");
            relativePath.Append($"\\{userId}");

            DirectoryInfo directoryInfo = new DirectoryInfo(relativePath.ToString());

            if (!directoryInfo.Exists)
            {
                Directory.CreateDirectory(relativePath.ToString());
            }

            return directoryInfo.ToString();
        }

        /// <summary>
        /// Add image in file system.
        /// </summary>
        /// <param name="userPath"></param>
        /// <param name="filePath"></param>
        /// <param name="imageToSave"></param>
        private void AddImage(string userPath, string filePath, IFormFile imageToSave)
        {
            if (Directory.EnumerateFiles(userPath).Count() > 0)
            {
                var file = Directory.EnumerateFiles(userPath).First();

                File.Delete(file);
            }


            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                imageToSave.CopyTo(fileStream);
            }
        }

    }
}
