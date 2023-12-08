namespace BicycleApp.Services.Contracts.Factory
{
    using BicycleApp.Data.Models.EntityModels;

    public interface IRatingFactory
    {
        Task<Rate> CreateRate(string userId, int partId, int rating);
    }
}
