using BicycleApp.Data;
using BicycleApp.Services.Contracts;
using BicycleApp.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace BicycleApp.Services.Services
{
    public class DropdownsContentService : IDropdownsContentService
    {

        private readonly BicycleAppDbContext _dbContext;

        public DropdownsContentService(BicycleAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Gets all avaiable frames in database
        /// </summary>
        /// <returns>Dto's collection of all avaiable frames in database</returns>
        public async Task<ICollection<PartInfoDto>> GetAllFrames()
        {
            try
            {
                var result = await _dbContext.Parts
                .AsNoTracking()
                .Where(p => p.Category.Id == 1)
                .Select(p => new PartInfoDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Type = p.Type,
                })
                .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Database can't retrive data");
            }
        }

        /// <summary>
        /// Gets all avaiable tyres in database
        /// </summary>
        /// <returns>Dto's collection of all avaiable tyres in database</returns>
        public async Task<ICollection<PartInfoDto>> GetAllWheels()
        {
            try
            {
                var result = await _dbContext.Parts
                .AsNoTracking()
                .Where(p => p.Category.Id == 2)
                .Select(p => new PartInfoDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Type = p.Type,
                })
                .ToListAsync();

                return result;
            }
            catch (Exception ex )
            {

                throw new ArgumentException("Database can't retrive data");
            }
        }

        /// <summary>
        /// Gets all avaiable acsessories in database
        /// </summary>
        /// <returns>Dto's collection of all avaiable acsessories in database</returns>
        public async Task<ICollection<PartInfoDto>> GetAllAcsessories()
        {
            try
            {
                var result = await _dbContext.Parts
                .AsNoTracking()
                .Where(p => p.Category.Id == 3)
                .Select(p => new PartInfoDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Type = p.Type,
                })
                .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Database can't retrive data");
            }
        }
        /// <summary>
        /// Gets avaible part by id in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns> part Dto by id from database</returns>
        public async Task<PartDto> GetPartByIdAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException(nameof(id));
            }

            try
            {
                var result = await _dbContext.Parts
                .Where(p => p.Id == id)
                .AsNoTracking()
                .Select(p => new PartDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImagesParts.First().ImageUrl,
                    Type = p.Type,
                    SalePrice = p.SalePrice,
                    OEMNumber = p.OEMNumber,
                    Rating = p.Rates.Average(r => r.Rating)
                })
                .FirstAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Database can't retrive data");
            }
        }
    }
}
