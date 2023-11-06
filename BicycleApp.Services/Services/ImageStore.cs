namespace BicycleApp.Services.Services
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;
    using System.Text;
    using System.Threading.Tasks;

    public class ImageStore : IImageStore
    {
        private readonly BicycleAppDbContext _db;

        public ImageStore(BicycleAppDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Return users image as byte[].
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userRole"></param>
        /// <returns>byte[]</returns>
        public async Task<byte[]> GetUserImage(string userId, string userRole)
        {
            string userPath = string.Empty;

            try
            {
                if (userRole.ToLower() != "client")
                {
                    userPath = _db.ImagesEmployees.First(e => e.EmployeeId == userId).ImageUrl;
                }
                else
                {
                    userPath = _db.ImagesClients.First(e => e.ClientId == userId).ImageUrl;
                }

                var currentDirectory = Directory.GetCurrentDirectory();
                var fullPath = Path.Combine(currentDirectory, userPath);

                var file = Directory.GetFiles(fullPath).FirstOrDefault();

                if (file != null && File.Exists(file))
                {
                    return await File.ReadAllBytesAsync(file);
                }
            }
            catch (Exception)
            {
                return new byte[] { };
            }
            return new byte[] { };
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
                        if (Directory.EnumerateFiles(userPath).Count() > 0)
                        {                            
                            var file = Directory.EnumerateFiles(userPath).First();

                            File.Delete(file);
                        }

                        string fileName = Guid.NewGuid().ToString();
                        string filePath = Path.Combine(userPath, $"{fileName}.{imageExtension}");

                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            userImageDto.ImageToSave.CopyTo(fileStream);
                        }


                        if (userImageDto.Role.ToLower() != "client")
                        {
                            var employee = _db.ImagesEmployees.FirstOrDefault(e => e.EmployeeId == userImageDto.Id);

                            if (employee == null)
                            {
                                var employeeImage = new ImageEmployee()
                                {
                                    EmployeeId = userImageDto.Id,
                                    ImageName = fileName,
                                    ImageUrl = filePath
                                };

                                _db.ImagesEmployees.Add(employeeImage);
                            }
                            else
                            {
                                employee.ImageName = fileName;
                                employee.ImageUrl = filePath;

                                _db.ImagesEmployees.Update(employee);
                            }                            
                        }
                        else
                        {
                            var client = _db.ImagesClients.FirstOrDefault(e => e.ClientId == userImageDto.Id);

                            if (client == null)
                            {
                                var clientImage = new ImageClient()
                                {
                                    ClientId = userImageDto.Id,
                                    ImageName = fileName,
                                    ImageUrl = filePath
                                };

                                _db.ImagesClients.Add(clientImage);
                            }
                            else
                            {
                                client.ImageName = fileName;
                                client.ImageUrl = filePath;

                                _db.ImagesClients.Update(client);
                            }                            
                        }

                        await _db.SaveChangesAsync();

                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
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
            var relativePath = new StringBuilder("wwwroot\\files\\profiles\\"); 

            switch(role.ToLower())
            {
                case "manager":
                    relativePath.Append("managers");
                    break;
                case "employee":
                    relativePath.Append("workers");
                    break;
                default:
                    relativePath.Append("users");
                    break;
            }

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
                
    }
}
