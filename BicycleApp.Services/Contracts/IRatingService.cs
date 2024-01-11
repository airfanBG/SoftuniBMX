namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.Rating.Contracts;

    public interface IRatingService
    {
        Task<bool> SetRating(IRatingDto ratingInfo);
        Task<double> GetAverageRatePerPart(int partId);
        Task<bool> UpdateRating(IRatingDto ratingInfo);
        Task<bool> RemoveRating(IRatingDto ratingInfo);
        Task<bool> ClientRateExists(int partId, string clientId);
    }
}
