namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.Order;

    public interface IOrderService
    {
        Task<bool> CreateOrderByUserAsync(OrderDto order);
        Task<bool> AcceptAndCreateOrderByManagerAsync(ManagerApprovalDto managerApprovalDto);
        Task AssigningOrderToEmployee(string managerId,string employeeId, int orderId, int partId);
        Task<ICollection<OrderInfoDto>> AllPendingOrdersAsync(string managerId);
        Task<ICollection<OrderInfoDto>> GetAllFinishedOrdersForPeriod(DateTime startDate, DateTime endDate);
        Task ManagerOrderRejection(int orderId);
        Task<bool> ChangeStatus(int orderId, int statusId);
        Task EmployeeEndProduction(string employeeId, int orderId, int partId);
        Task EmployeeStartProduction(string employeeId, int orderId, int partId);
        Task<bool> ArePartsAvailable(int partsInOrder, int partInStockId);

        //There must be a saved history of order(In OrdersPartsEmployees table should have quantity and price property)
        //void UserEditOrder(string userId, int orderId);
        Task<ICollection<EmployeePartTaskDto>> EmployeeUnfinishedTask(string employeeId);
    }
}
