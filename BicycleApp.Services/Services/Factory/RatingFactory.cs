namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using System.Threading.Tasks;

    public class RatingFactory : IRatingFactory
    {        
        public async Task<Rate> CreateRate(string userId, int partId, int rating)
        {
            return new Rate()
            {
               ClientId = userId,
               PartId = partId,
               Rating = rating,
            };
        }
    }
}
