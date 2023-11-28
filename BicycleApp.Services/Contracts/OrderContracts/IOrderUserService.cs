namespace BicycleApp.Services.Contracts.OrderContracts
{
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Models.Order.Contracts;

    public interface IOrderUserService
    {
        Task<bool> CreateOrderByUserAsync(IUserOrderDto order);
        //Task<ICollection<OrderProgretionDto>> GetOrdersProgresions(string userId);
        //Task<ICollection<OrderProgretionDto>> AllPendingApprovalOrder(string userId);
    }
}
