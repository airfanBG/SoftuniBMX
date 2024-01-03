namespace BicycleApp.Services.Contracts.Factory
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public interface IOrderFactory
    {
        Task<Order?> CreateUserOrder(IOrder order, DateTime currentTime);
        public Task<IOrderPartDto> CreateOrderPartFromUserOrder(string partName, int partQuantity, int partId, decimal productPrice);
        public Task<OrderPartEmployee> CreateOrderPartEmployeeProduct(int orderId, string uniqueKeyForSerialNumber, string serialNumber, int partId, string partName, int partQuantity, decimal partPrice, DateTime currentDate);
        public ISuccessOrderInfo CreateSuccessOrderItems(IOrderPartsEmplyee successOrder);
    }
}
