namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.Bike;
    using BicycleApp.Services.Models.Part;

    public interface IBikeService
    {
        Task<bool> AddBikeModelAsync(BikeStandartTypeAddDto bikeStandartTypeAddDto);

        Task<bool> EditBikeModelAsync(BikeStandartTypeEditDto bikeStandartTypeEditDto);

        Task<List<PartShortInfoDto>> GetAllParts();

        Task<BikeStandartTypeEditDto?> GetBikeModelAsync(int id);
    }
}
