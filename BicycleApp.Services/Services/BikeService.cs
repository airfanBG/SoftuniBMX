namespace BicycleApp.Services.Services
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;

    using Microsoft.EntityFrameworkCore;

    public class BikeService : IBikeService
    {
        private readonly BicycleAppDbContext dbContext;
        private readonly IModelsFactory modelsFactory;

        public BikeService(BicycleAppDbContext dbContext, IModelsFactory modelsFactory)
        {
            this.dbContext = dbContext;
            this.modelsFactory = modelsFactory;
        }

        /// <summary>
        /// This method cretes a new bike model in the database
        /// </summary>
        /// <param name="bikeStandartTypeAddDto">Info for the bike</param>
        /// <returns>True/False</returns>
        public async Task<bool> AddBikeModelAsync(BikeStandartTypeAddDto bikeStandartTypeAddDto)
        {
            if (bikeStandartTypeAddDto == null)
            {
                return false;
            }

            BikeStandartModel bikeModel = modelsFactory.CreateNewBikeStandartModel(bikeStandartTypeAddDto);

            await dbContext.BikesStandartModels.AddAsync(bikeModel);

            List<BikeModelPart> bikeModelParts = new List<BikeModelPart>();
            foreach (var id in bikeStandartTypeAddDto.Parts)
            {
                Part? part = await dbContext.Parts.FirstOrDefaultAsync(p => p.Id == id);
                if (part == null)
                {
                    continue;
                }

                bikeModelParts.Add(new BikeModelPart()
                {
                    BikeModelId = bikeModel.Id,
                    PartId = part.Id
                });
            }

            await dbContext.BikeModelsParts.AddRangeAsync(bikeModelParts);
            await dbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// This method changes the data of a bike model in the database
        /// </summary>
        /// <param name="bikeStandartTypeEditDto"></param>
        /// <returns></returns>
        public async Task<bool> EditBikeModelAsync(BikeStandartTypeEditDto bikeStandartTypeEditDto)
        {
            if (bikeStandartTypeEditDto == null)
            {
                return false;
            }

            BikeStandartModel? bike = await dbContext.BikesStandartModels
                .FirstOrDefaultAsync(b => b.Id == bikeStandartTypeEditDto.Id);

            if (bike == null)
            {
                return false;
            }

            bike.ModelName = bikeStandartTypeEditDto.ModelName == null ? bike.ModelName : bikeStandartTypeEditDto.ModelName;

            bike.Description = bikeStandartTypeEditDto.Description == null ? bike.Description : bikeStandartTypeEditDto.Description;

            bike.ImageUrl = bikeStandartTypeEditDto.ImageUrl == null ? bike.ImageUrl : bikeStandartTypeEditDto.ImageUrl;

            bike.Price = bikeStandartTypeEditDto.Price.HasValue == true ? bikeStandartTypeEditDto.Price.Value : bike.Price;

            BikeModelPart[] maps = await dbContext.BikeModelsParts
                .Where(b => b.BikeModelId == bike.Id)
                .ToArrayAsync();

            dbContext.BikeModelsParts.RemoveRange(maps);

            foreach (var id in bikeStandartTypeEditDto.Parts)
            {
                bike.BikeModelsParts.Add(new BikeModelPart()
                {
                    BikeModelId = bike.Id,
                    PartId = id
                });
            }

            await dbContext.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Returns all part info in the database
        /// </summary>
        /// <returns>List</returns>
        public async Task<List<PartShortInfoDto>> GetAllParts()
        {
            return await dbContext.Parts
                .AsNoTracking()
                .Select(p => new PartShortInfoDto()
                {
                    Id = p.Id,
                    Name = p.Name
                })
                .ToListAsync();
        }

        /// <summary>
        /// This methos returns info abouth the bike model
        /// </summary>
        /// <param name="id">Id of the model</param>
        /// <returns>Dto of Null</returns>
        public async Task<BikeStandartTypeEditDto?> GetBikeModelAsync(int id)
        {
            BikeStandartTypeEditDto? bike = await dbContext.BikesStandartModels
                 .Where(b => b.Id == id)
                 .Select(b => new BikeStandartTypeEditDto()
                 {
                     Id = b.Id,
                     Description = b.Description,
                     ImageUrl = b.ImageUrl,
                     ModelName = b.ModelName,
                     Price = b.Price,
                     Parts = b.BikeModelsParts.Select(p => p.PartId).ToHashSet()
                 })
                 .FirstOrDefaultAsync();

            return bike;
        }
    }
}
