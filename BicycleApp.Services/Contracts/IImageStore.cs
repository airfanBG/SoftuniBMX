namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models;

    public interface IImageStore
    {
        Task<bool> IsAddedOrReplacedUserImage(UserImageDto userImageDto);
        Task<string?> GetUserImage(string userId, string userRole);
    }
}
