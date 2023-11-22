namespace BicycleApp.Services.Contracts.OrderContracts
{
    using BicycleApp.Services.Models.Order;

    public interface IOrderUserService
    {
        Task<bool> CreateOrderByUserAsync(UserOrderDto order);
        Task<ICollection<OrderProgretionDto>> GetOrdersProgresions(string userId);
    }
}
