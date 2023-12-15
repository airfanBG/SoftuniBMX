namespace BicycleApp.Services.Services
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Rating.Contracts;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class RatingService : IRatingService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IRatingFactory _ratingFactory;
        private readonly IDateTimeProvider _dateTimeProvider;

        public RatingService(BicycleAppDbContext db, IRatingFactory ratingFactory, IDateTimeProvider dateTimeProvider)
        {
            _db = db;
            _ratingFactory = ratingFactory;
            _dateTimeProvider = dateTimeProvider;
        }

        public async Task<double> GetAverageRatePerPart(int partId)
        {
            return await _db.Rates
                            .AsNoTracking()
                            .Where(r => r.PartId == partId 
                                        && r.IsDeleted == false)
                            .AverageAsync(r=>r.Rating);
        }

        public async Task<bool> RemoveRating(IRatingDto ratingInfo)
        {
            try
            {
                var rating = await _db.Rates.FirstAsync(r => r.ClientId == ratingInfo.ClientId 
                                                             && r.PartId == ratingInfo.PartId 
                                                             && r.DateDeleted == null 
                                                             && r.IsDeleted == false);
                rating.DateDeleted = _dateTimeProvider.Now;
                rating.IsDeleted = true;

                _db.Rates.Update(rating);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public async Task<bool> SetRating(IRatingDto ratingInfo)
        {
            try
            {
                var rating = await _ratingFactory.CreateRate(ratingInfo.ClientId, ratingInfo.PartId, ratingInfo.Rating);
                rating.DateCreated = _dateTimeProvider.Now;

                await _db.Rates.AddAsync(rating);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public async Task<bool> UpdateRating(IRatingDto ratingInfo)
        {
            try
            {
                var rating = await _ratingFactory.CreateRate(ratingInfo.ClientId, ratingInfo.PartId, ratingInfo.Rating);
                rating.DateUpdated = _dateTimeProvider.Now;

                _db.Rates.Update(rating);
                await _db.SaveChangesAsync();

                return true;

            }
            catch (Exception)
            {
            }
            return false;
        }
    }
}
