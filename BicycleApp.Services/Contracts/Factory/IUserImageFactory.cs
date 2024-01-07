namespace BicycleApp.Services.Contracts.Factory
{
    using BicycleApp.Data.Interfaces;

    public interface IUserImageFactory
    {
        public Task<string?> GetUserImagePathAsync(string userId, string userRole);
        public Task<bool> CheckForExistingUserImage(string userId, string userRole);
        public Task<IUserImage?> UpdateUserImage(string userId, string userRole, string filePath, string imageName);
        public Task<IUserImage?> CreateUserImage(string userId, string userRole, string filePath, string imageName);
    }
}
