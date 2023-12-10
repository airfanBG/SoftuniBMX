namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models;

    public interface IBikeService
    {
        Task<bool> AddBikeModelAsync(BikeStandartTypeAddDto bikeStandartTypeAddDto);

        Task<bool> EditBikeModelAsync(BikeStandartTypeEditDto bikeStandartTypeEditDto);

        Task<List<PartShortInfoDto>> GetAllParts();

        Task<BikeStandartTypeEditDto?> GetBikeModelAsync(int id);
    }
}
