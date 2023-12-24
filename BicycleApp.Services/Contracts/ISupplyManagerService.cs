using BicycleApp.Services.Models;
using BicycleApp.Services.Models.Order;
using BicycleApp.Services.Models.Supply;

namespace BicycleApp.Services.Contracts
{
    public interface ISupplyManagerService
    {
        Task<bool> DeliveryExists(int deliveryId);
        Task<bool> SuplierExists(int suplierId);
        Task<bool> PartOrderExists(int partOrderId);
        Task<DeliveryQueryDto> AllDeliveries(int currPage);
        Task<ICollection<SuplierInfoDto>> AllSupliers();
        Task<ICollection<PartOrderInfoDto>> AllPartOrders();
        Task<bool> CreateSuplier(CreateSuplierDto createSuplierDto);
        Task<bool> CreateDelivedry(CreateDelivedryDto createDelivedryDto);
        Task<bool> CreatePartOrder(CreatePartOrderDto createPartOrderryDto);
        Task<DeliveryDetailsDto> DeliveryDetailsById(int deliveryId);
        Task<SuplierDetailsDto> SuplierDetailsById(int suplierId);
        Task<PartOrderDetailsDto> PartOrderDetailsById(int partOrderId);
        Task<bool> EditSuplierById(EditSuplierDto editSuplierDto);
        Task<bool> EditDeliveryById(EditDelivedryDto editeDelivedryDto);
        Task<bool> EditPartOrderById(EditPartOrderDto editePartOrderDto);
        Task DeleteSuplierById(int suplierId);
        Task DeleteDeliveryById(int deliveryId);
        Task DeletePartOrderById(int partOrderId);
        Task<PartQueryDto> AllPartsInStock(int currentPage);

        //Task UpdateSuplierPartsInStock(int suplierId, int[] suppliedPartsOemNums);
    }
}
