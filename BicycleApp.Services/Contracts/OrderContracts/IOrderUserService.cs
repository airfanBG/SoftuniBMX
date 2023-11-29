namespace BicycleApp.Services.Contracts.OrderContracts
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public interface IOrderUserService
    {
        Task<IOrderPartsEmplyee?> CreateOrderByUserAsync(IUserOrderDto order);
        Task<bool> CreateOrderPartEmployeeByUserOrder(IOrderPartsEmplyee newOrder);
        //Task<ICollection<OrderProgretionDto>> GetOrdersProgresions(string userId);
        //Task<ICollection<OrderProgretionDto>> AllPendingApprovalOrder(string userId);
    }
}
