namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.Image;

    public interface IImageStore
    {
        Task<bool> IsAddedOrReplacedUserImage(UserImageDto userImageDto);
        Task<string?> GetUserImage(string userId, string userRole, string httpScheme, string httpHost, string httpPathBase);
    }
}
