namespace BicycleApp.Services.Services.Factory
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public class OrderFactory : IOrderFactory
    {
        private readonly BicycleAppDbContext _db;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IStringManipulator _stringManipulator;
        public OrderFactory(BicycleAppDbContext db, IDateTimeProvider dateTimeProvider, IStringManipulator stringManipulator)
        {
            _db = db;
            _dateTimeProvider = dateTimeProvider;
            _stringManipulator = stringManipulator;
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
                Descrioption = _stringManipulator.GetTextFromProperty(description)
            };
        }

        public async Task<OrderPartEmployee> CreateOrderPartEmployeeProduct(int orderId, string uniqueKeyForSerialNumber, string serialNumber, int partId, string partName, int partQuantity, decimal partPrice, string? description)
        {
            var ope = new OrderPartEmployee()
            {
                OrderId = orderId,
                PartId = partId,
                PartQuantity = partQuantity,
                PartName = partName,
                PartPrice = partPrice,
                SerialNumber = serialNumber,
                UniqueKeyForSerialNumber = uniqueKeyForSerialNumber
            };

            return  ope;
        }

        public ISuccessOrderInfo CreateSuccessOrderItems(IOrderPartsEmplyee successOrder)
        {
            return new SuccessOrderInfo()
            {
                OrderId = successOrder.OrderId,
                ClientId = successOrder.ClientId,
                FinalAmount = successOrder.FinalAmount,
                PaidAmount = successOrder.PaidAmount,
                SaleAmount = successOrder.SaleAmount,
                UnpaidAmount = successOrder.UnpaidAmount,
                VAT = successOrder.VAT,
                Description = _stringManipulator.GetTextFromProperty(successOrder.Description),
                Discount = successOrder.Discount,
                OrderParts = successOrder.OrderParts.Select(op => new OrderPartDto()
                {
                    Descrioption = op.Descrioption,
                    PartId = op.PartId,
                    PartName = op.PartName,
                    PartPrice = op.PartPrice * successOrder.OrderQuantity,
                    PartQuantity = successOrder.OrderQuantity
                }).ToList()
            };
        }
    }
}
