namespace BicycleApp.Services.Contracts.OrderContracts
{
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public interface IOrderUserService
    {
        Task<IOrderPartsEmplyee?> CreateOrderByUserAsync(IUserOrderDto order);
        Task<bool> CreateOrderPartEmployeeByUserOrder(IOrderPartsEmplyee newOrder);
        Task<ICollection<OrderProgretionDto>> GetOrdersProgresions(string userId);
        Task<ICollection<OrderProgretionDto>> AllPendingApprovalOrder(string userId);
        ISuccessOrderInfo SuccessCreatedOrder(IOrderPartsEmplyee successOrder);
        Task DeleteOrder(string userId, int orderId);
        Task<bool> DeductionByAmount(string clientId, decimal percentageOfDeduction, IOrder newOrder);
        Task<ICollection<OrderClientShortInfo>> GetAllOrdersForClientByStatus(string userId, int status);

        Task<OrderDtoInfo?> GetOrderById(int orderId);
    }
}
