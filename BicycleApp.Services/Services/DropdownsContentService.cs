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
        /// Gets all avaiable compatible parts in database
        /// </summary>
        /// <returns>Dto's collection of all avaiable compatible parts in database</returns>
        public async Task<ICollection<PartDto>> GetAllCompatibleParts(int selectedPartId)
        {

            if (selectedPartId <= 0)
            {
                throw new ArgumentNullException(nameof(selectedPartId));
            }

            var selectedPart = await _dbContext.Parts
                .Where(p => p.Id == selectedPartId)
                .FirstOrDefaultAsync();

            if (selectedPart == null)
            {
                throw new ArgumentNullException(nameof(selectedPart));
            }

            try
            {

                var result = await _dbContext.Parts
                .AsNoTracking()
                .Include(p => p.Rates)
                .Where(p => p.Category.Id != 1
                            && p.Type == selectedPart.Type)
                .Select(p => new PartDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.Name,
                    Description = p.Description,
                    Intend = p.Intend,
                    Type = p.Type,
                    SalePrice = p.SalePrice,
                    ImageUrls = p.ImagesParts.Where(p => p.PartId == p.Id)
                    .Select(ip => ip.ImageUrl).ToList(),
                    OEMNumber = p.OEMNumber,
                    Rating = (int)Math.Ceiling(p.Rates
                                    .Where(r => r.PartId == p.Id)
                                    .Select(r => r.Rating)
                                    .Average())

                })
                .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Database can't retrive data", ex);
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
                .AsNoTracking()
                .Include(p=>p.Rates)
                .Where(p => p.Id == id)
                .Select(p => new PartDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Category = p.Category.Name,
                    Description = p.Description,
                    Intend = p.Intend,
                    Type = p.Type,
                    SalePrice = p.SalePrice,
                    ImageUrls = GetImageUrls(id),
                    OEMNumber = p.OEMNumber,
                    Rating = (int)Math.Ceiling(p.Rates
                                    .Where(r => r.PartId == p.Id)
                                    .Select(r => r.Rating)
                                    .Average())
                })
                .FirstAsync();

                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Database can't retrive data", ex);
            }
        }

        /// <summary>
        /// Gets avaible images by partId in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns> List of imageUrls from database</returns>

        private List<string> GetImageUrls(int partId)
        {

            //Get all imageUrls for the part
            List<string> imageUrls = _dbContext.ImagesParts
                .AsNoTracking()
                .Where(p => p.Id == partId)
                .Select(ip => ip.ImageUrl)
                .ToList();

            return imageUrls;
        }
    }
}
