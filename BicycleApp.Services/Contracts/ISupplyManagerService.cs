using BicycleApp.Services.Models.Supply;

namespace BicycleApp.Services.Contracts
{
    public interface ISupplyManagerService
    {
        Task<bool> DeliveryExists(int deliveryId);
        Task<bool> SuplierExists(int suplierId);
        Task<DeliveryInfoDto> AllDeliveries(//by client
                            string category_suplier = null,
                            string searchTerm_client = null,
                            DeliveriesSorting sorting = DeliveriesSorting.Newest,
                            int currentPage = 1,
                            int deliveriesPerPage = 1);
        Task<SupplierInfoDto> AllSuppliers();

        Task<DeliveryDetailsDto> DeliveryDetails(int deliveryId);

        Task<SuplierDetailsDto> SuplierDetails(int suplierId);

        Task CreateSuplier(CreateSuplierDto createSuplierDto);

        Task CreateDelivedry(CreateDelivedryDto createDelivedryDto);

        Task EditSuplier(int suplierId, CreateSuplierDto createSuplierDto);

        Task EditDelivedry(int vehicleId, CreateDelivedryDto createDelivedryDto);

        Task DeleteSuplier(int suplierId);

        Task DeleteDelivedry(int deliveryId);
    }
}
