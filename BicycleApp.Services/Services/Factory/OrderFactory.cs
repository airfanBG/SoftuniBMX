namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public class OrderFactory : IOrderFactory
    {  
        public Order? CreateUserOrder(IOrder order, DateTime currentTime)
        {
             return new Order()
             {
                 FinalAmount = order.FinalAmount,
                 PaidAmount = order.PaidAmount,
                 SaleAmount = order.SaleAmount,
                 UnpaidAmount = order.UnpaidAmount,
                 VAT = order.VAT,
                 ClientId = order.ClientId,
                 DateCreated = currentTime,
                 Description = order.Description,
                 Discount = order.Discount,
                 IsDeleted = order.IsDeleted,
                 StatusId = order.StatusId
             };
        }
        public OrderPartDto CreateOrderPartFromUserOrder(string partName, int partQuantity, int partId, decimal productPrice)
        {
            return new OrderPartDto()
            {
                PartName = partName,
                PartQuantity = partQuantity,
                PartId = partId,
                PartPrice = productPrice
            };
        }

        public OrderPartEmployee CreateOrderPartEmployeeProduct(int orderId, string uniqueKeyForSerialNumber, string serialNumber, int partId, string partName, int partQuantity, decimal partPrice, DateTime currentDate)
        {
            var ope = new OrderPartEmployee()
            {
                OrderId = orderId,
                PartId = partId,
                PartQuantity = partQuantity,
                PartName = partName,
                PartPrice = partPrice,
                SerialNumber = serialNumber,
                UniqueKeyForSerialNumber = uniqueKeyForSerialNumber,
                DateCreated = currentDate
            };

            return  ope;
        }

        public SuccessOrderInfo CreateSuccessOrderItems(IOrderPartsEmplyee successOrder)
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
                Discount = successOrder.Discount,
                Description = successOrder.Description,
                OrderParts = successOrder.OrderParts.Select(op => new OrderPartDto()
        {
                    PartId = op.PartId,
                    PartName = op.PartName,
                    PartPrice = op.PartPrice * successOrder.OrderQuantity,
                    PartQuantity = successOrder.OrderQuantity
                }).ToList()
            };
        }
    }
}
