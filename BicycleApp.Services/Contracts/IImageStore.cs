namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models;
    using Microsoft.AspNetCore.Http;

    public interface IImageStore
    {
        Task<bool> IsAddedOrReplacedUserImage(UserImageDto userImageDto);
        Task<byte[]> GetUserImage(string userId, string userRole);
    }
}
