namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Data.Models.IdentityModels;

    public interface IFactory
    {
        public Task<BaseUser?> GetUserAsync(string userId, string userRole);
        public Task<string?> GetUserImagePathAsync(string userId, string userRole);
        public Task<bool> CheckForExistingUserImage(string userId, string userRole);
        public Task<bool> UpdateUserImage(string userId, string userRole, string filePath);
        public Task<bool> CreateUserImage(string userId, string userRole, string filePath, string imageName);
    }
}
