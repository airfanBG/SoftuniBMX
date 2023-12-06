using BicycleApp.Services.Models.Supply;

namespace BicycleApp.Services.Contracts
{
    public interface ISupplyManagerService
    {
        Task<bool> DeliveryExists(int deliveryId);
        Task<bool> SuplierExists(int suplierId);
        Task<DeliveryQueryDto> AllDeliveries(int currPage);
        Task<SupplierInfoDto> AllSuppliers();

        Task<DeliveryDetailsDto> DeliveryDetails(int deliveryId);

        Task<SuplierDetailsDto> SuplierDetails(int suplierId);

        Task CreateSuplier(CreateSuplierDto createSuplierDto);

        Task CreateDelivedry(CreateDelivedryDto createDelivedryDto);

        Task EditSuplier(int suplierId, CreateSuplierDto createSuplierDto);

        Task EditDelivedry(int vehicleId, CreateDelivedryDto createDelivedryDto);

        Task DeleteSuplier(int suplierId);

        Task DeleteDelivedry(int deliveryId);

        Task UpdateSuplierPartsInStock(int suplierId, int[] suppliedPartsOemNums);
    }
}
