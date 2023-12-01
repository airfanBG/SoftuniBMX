namespace BicycleApp.Services.Contracts.Factory
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public interface IOrderFactory
    {
        Task<int> CreateUserOrderAsync(IOrder order);
        public IOrderPartDto CreateOrderPartFromUserOrder(string partName, int partQuantity, int partId, decimal productPrice);
        public Task<OrderPartEmployee> CreateOrderPartEmployeeProduct(int orderId, string UniqueKeyForSerialNumber, string SerialNumber, int PartId, string PartName, int PartQuantity, decimal PartPrice);
        public ISuccessOrderInfo CreateSuccessOrderItems(IOrderPartsEmplyee successOrder);
    }
}
