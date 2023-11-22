namespace BicycleApp.Services.Contracts.Factory
{
    using BicycleApp.Data.Models.IdentityModels;

    public interface IUserFactory
    {
        public Task<BaseUser?> GetUserAsync(string userId, string userRole);
    }
}
