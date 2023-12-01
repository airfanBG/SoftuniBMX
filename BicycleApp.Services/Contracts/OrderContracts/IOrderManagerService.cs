namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.Order.OrderManager;

    public interface IOrderManagerService
    {
        Task<bool> AcceptAndAssignOrderByManagerAsync(int orderId);
        Task<ICollection<OrderInfoDto>> AllPendingOrdersAsync();
        Task<ICollection<OrderInfoDto>> GetAllFinishedOrdersForPeriod(DateTime startDate, DateTime endDate);
        Task<bool> ArePartsAvailable(int partsInOrder, int partInStockId);
        Task ManagerOrderRejection(int orderId);

        //Task<bool> ChangeStatus(int orderId, int statusId);
        //Task EmployeeEndProduction(string employeeId, int orderId, int partId);
        //Task EmployeeStartProduction(string employeeId, int orderId, int partId);        
        //Task<ICollection<EmployeePartTaskDto>> EmployeeUnfinishedTask(string employeeId);
    }
}
