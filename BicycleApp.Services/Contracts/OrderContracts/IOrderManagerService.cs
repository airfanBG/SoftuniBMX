namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.IdentityModels;
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Models.Order.OrderManager;
    using BicycleApp.Services.Models.Order.OrderUser;
    using System.Threading.Tasks;

    public interface IOrderManagerService
    {
        Task<int> AcceptAndAssignOrderByManagerAsync(int orderId);
        Task<OrderQueryDto> AllPendingOrdersAsync(int currentPage);
        Task<ICollection<OrderProgretionDto>> GetAllFinishedOrdersForPeriod(FinishedOrdersDto datesPeriod);
        Task<int> ArePartsNeeded(int partsInOrder, int partInStockId);
        Task<int> ManagerDeleteOrder(int orderId);
        Task<string> SetEmployeeToPart(int partId);
        Task <ICollection<OrderPartDeliveryDto>> RejectOrderAsync(int orderId);
        Task<ICollection<OrderInfoDto>> AllRejectedOrdersAsync();
        Task<bool> AcceptAndAssignRejectedOrderByManagerAsync(int orderId);
        Task<ICollection<OrderProgretionDto>> AllOrdersInProgressAsync();
        Task<ICollection<EmployeeInfoDto>> GetAllEmployees();
        Task<int> GetTotalProductionTime(int orderId);
        Task<OrderQueryDto> AllDeletedOrdersAsync(int currentPage);
        Task<ICollection<OrderSendedDto>> AllSendedOrdersAsync();
        Task<bool> SendOrderAsync(int orderId);
        Task <OrderStatisticDto> GetOrderStatistics(FinishedOrdersDto datesPeriod);
        Task <PartStatisticDto> GetPartStatistics(FinishedOrdersDto datesPeriod);
        Task <StatisticsDto> GetStatistics(FinishedOrdersDto datesPeriod);
    }
}
