namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Models.Order.OrderManager;
    using System.Threading.Tasks;

    public interface IOrderManagerService
    {
        Task<bool> AcceptAndAssignOrderByManagerAsync(int orderId);
        Task<ICollection<OrderInfoDto>> AllPendingOrdersAsync();
        Task<ICollection<OrderInfoDto>> GetAllFinishedOrdersForPeriod(FinishedOrdersDto datesPeriod);
        Task<int> ArePartsNeeded(int partsInOrder, int partInStockId);
        Task ManagerDeleteOrder(int orderId);
        Task<string> SetEmployeeToPart(int partId);
        Task <ICollection<OrderPartDeliveryDto>> RejectOrderAsync(int orderId);
        Task<ICollection<OrderInfoDto>> AllRejectedOrdersAsync();
        Task<bool> AcceptAndAssignRejectedOrderByManagerAsync(int orderId);
        Task<ICollection<OrderInfoDto>> AllOrdersInProgressAsync();

        //Task<bool> ChangeStatus(int orderId, int statusId);
        //Task EmployeeEndProduction(string employeeId, int orderId, int partId);
        //Task EmployeeStartProduction(string employeeId, int orderId, int partId);        
        //Task<ICollection<EmployeePartTaskDto>> EmployeeUnfinishedTask(string employeeId);
    }
}
