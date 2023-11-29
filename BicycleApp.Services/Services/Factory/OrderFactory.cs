namespace BicycleApp.Services.Services.Factory
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public class OrderFactory : IOrderFactory
    {
        private readonly BicycleAppDbContext _db;
        private readonly IDateTimeProvider _dateTimeProvider;
        public OrderFactory(BicycleAppDbContext db, IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
            _db = db;
        }
        public async Task<int> CreateUserOrderAsync(IOrder order)
        {
            try
            {
                var orderToSave = new Order()
                {
                    FinalAmount = order.FinalAmount,
                    PaidAmount = order.PaidAmount,
                    SaleAmount = order.SaleAmount,
                    UnpaidAmount = order.UnpaidAmount,
                    VAT = order.VAT,
                    ClientId = order.ClientId,
                    DateCreated = _dateTimeProvider.Now,
                    Description = order.Description,
                    Discount = order.Discount,
                    IsDeleted = order.IsDeleted,
                    StatusId = order.StatusId
                };

                await _db.Orders.AddAsync(orderToSave);
                await _db.SaveChangesAsync();

                return orderToSave.Id;
            }
            catch (Exception)
            {
            }
            return 0;
        }
        public IOrderPartDto CreateOrderPartFromUserOrder(string partName, int partQuantity, int partId, decimal productPrice, string? description)
        {
            return new OrderPartDto()
            {
                PartName = partName,
                PartQuantity = partQuantity,
                PartId = partId,
                PartPrice = productPrice,
                Descrioption = description
            };
        }

        public OrderPartEmployee CreateOrderPartEmployeeProduct(int orderId, string uniqueKeyForSerialNumber, string serialNumber, int partId, string partName, int partQuantity, decimal partPrice, string? description)
        {
            var ope = new OrderPartEmployee()
            {
                OrderId = orderId,
                PartId = partId,
                PartQuantity = partQuantity,
                PartName = partName,
                PartPrice = partPrice,
                SerialNumber = serialNumber,
                UniqueKeyForSerialNumber = serialNumber
            };

            return ope;
        }
    }
}
