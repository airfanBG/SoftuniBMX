using BicycleApp.Services.Models.Supply;

namespace BicycleApp.Services.Contracts
{
    public interface ISupplyManagerService
    {
        Task<bool> DeliveryExists(int deliveryId);
        Task<bool> SuplierExists(int suplierId);
        Task<DeliveryQueryDto> AllDeliveries(int currPage);
        Task<ICollection<SuplierInfoDto>> AllSupliers();
        Task<bool> CreateSuplier(CreateSuplierDto createSuplierDto);
        Task<bool> CreateDelivedry(CreateDelivedryDto createDelivedryDto);
        Task<DeliveryDetailsDto> DeliveryDetailsById(int deliveryId);
        Task<SuplierDetailsDto> SuplierDetailsById(int suplierId);
        Task<bool> EditSuplierById(EditSuplierDto editSuplierDto);

        Task<bool> EditDeliveryById(EditDelivedryDto editeDelivedryDto);

        Task DeleteSuplierById(int suplierId);

        Task DeleteDeliveryById(int deliveryId);

        Task UpdateSuplierPartsInStock(int suplierId, int[] suppliedPartsOemNums);
    }
}
