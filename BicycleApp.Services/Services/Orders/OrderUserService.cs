namespace BicycleApp.Services.Services.Orders
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Interfaces;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using Microsoft.EntityFrameworkCore;
    using static BicycleApp.Common.ApplicationGlobalConstants;

    public class OrderUserService : IOrderUserService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IStringManipulator _stringManipulator;
        private readonly IOrderFactory _orderFactory;
        private readonly IGuidProvider _guidProvider;

        public OrderUserService(BicycleAppDbContext db, 
                                IStringManipulator stringManipulator,
                                IOrderFactory orderFactory,
                                IGuidProvider guidProvider)
        {
            _db = db;
            _stringManipulator = stringManipulator;
            _orderFactory = orderFactory;
            _guidProvider = guidProvider;
        }

        /// <summary>
        /// Creating order in database.
        /// </summary>
        /// <param name="order"></param>
        /// <returns>Task<int></returns>
        public async Task<IOrderPartsEmplyee?> CreateOrderByUserAsync(IUserOrderDto order)
        {
            try
            {
                var newOrder = new OrderDto();
                newOrder.ClientId = order.ClientId;
                newOrder.StatusId = 1;

                decimal totalAmount = 0M;
                decimal totalDiscount = 0M;
                decimal totalVAT = 0M;

                var vatCategory = await _db.VATCategories.AsNoTracking().FirstAsync(v => v.Id == order.VATId);

                foreach (var orderPart in order.OrderParts)
                {
                    var currentPart = await _db.Parts.FirstAsync(p => p.Id == orderPart.PartId);
                    decimal currentProductTotalPrice = Math.Round(currentPart.SalePrice * order.OrderQuantity, 2);
                    totalAmount += currentProductTotalPrice;
                    decimal currentProductTotalDiscount = Math.Round(currentPart.Discount * order.OrderQuantity, 2);                   
                    totalDiscount += currentProductTotalDiscount;
                    if (currentProductTotalDiscount > currentProductTotalPrice)
                    {
                        return null;
                    }
                    totalVAT += Math.Round(((currentProductTotalPrice - currentProductTotalDiscount) * vatCategory.VATPercent) / (100 + vatCategory.VATPercent), 2);
                    decimal productPrice = currentProductTotalPrice - currentProductTotalDiscount;
                    var currentOrderPartToSave = _orderFactory.CreateOrderPartFromUserOrder(currentPart.Name, order.OrderQuantity, orderPart.PartId, productPrice, order.Description);
                    newOrder.OrderParts.Add(currentOrderPartToSave);
                }

                newOrder.Discount = totalDiscount;
                newOrder.FinalAmount = totalAmount - totalDiscount;
                newOrder.VAT = totalVAT;
                newOrder.SaleAmount = totalAmount - totalDiscount - totalVAT;

                var newOrderId = await _orderFactory.CreateUserOrderAsync(newOrder);
                newOrder.OrderId = newOrderId;

                if (newOrderId != 0)
                {
                    return newOrder;
                }
            }
            catch (Exception)
            {
            }
            return null;
        }

        /// <summary>
        /// Takes all unfinished orders for a specific user and returns information about the workmanship of the parts.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Task<ICollection<OrderProgretionDto>></returns>
        public async Task<ICollection<OrderProgretionDto>> GetOrdersProgresions(string userId)
        {
            return await _db.Orders
                            .Include(o => o.OrdersPartsEmployees)
                                .ThenInclude(ope => ope.Employee)
                            .Include(o => o.OrdersPartsEmployees)
                                .ThenInclude(ope => ope.Part)
                            .ThenInclude(part => part.Category)
                            .Where(o => o.ClientId == userId && o.IsDeleted == false && o.DateFinish == null)
                            .Select(o => new OrderProgretionDto()
                            {
                                OrderId = o.Id,
                                SerialNumber = o.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                                DateCreated = o.DateCreated.ToString(DefaultDateFormat),
                                OrderStates = o.OrdersPartsEmployees
                                               .Select(ope => new OrderStateDto()
                                               {
                                                   IsProduced = ope.IsCompleted,
                                                   NameOfEmplоyeeProducedThePart = _stringManipulator.ReturnFullName(ope.Employee.FirstName, ope.Employee.LastName),
                                                   PartModel = ope.Part.Name,
                                                   PartType = ope.Part.Category.Name,
                                                   PartId = ope.PartId
                                                   
                                               }).ToList()
                            })
                            .ToListAsync();
        }

        public async Task<bool> CreateOrderPartEmployeeByUserOrder(IOrderPartsEmplyee newOrder)
        {
            try
            {               
                var orderPartEmployeeCollection = new List<OrderPartEmployee>();
                
                int quntityOfPart = newOrder.OrderParts.Select(op => op.PartQuantity).First();

                for (int i = 0; i < quntityOfPart; i++)
                {
                    string serialNumber = _stringManipulator.SerialNumberGenerator();
                    string guidKey = _guidProvider.CreateGuid();

                    foreach (var orderPart in newOrder.OrderParts)
                    {
                        var ope = _orderFactory.CreateOrderPartEmployeeProduct(newOrder.OrderId, guidKey, serialNumber, orderPart.PartId, orderPart.PartName, orderPart.PartQuantity, orderPart.PartPrice, orderPart.Descrioption);
                        
                        orderPartEmployeeCollection.Add(ope);
                    }
                }

                await _db.OrdersPartsEmployees.AddRangeAsync(orderPartEmployeeCollection);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
        public async Task<ICollection<OrderProgretionDto>> AllPendingApprovalOrder(string userId)
        {
            return await _db.Orders
                            .Where(o => o.DateUpdated.Equals(null))
                            .Select(o => new OrderProgretionDto()
                            {
                                DateCreated = o.DateCreated.ToString(DefaultDateFormat),
                                OrderId = o.Id,
                                SerialNumber = o.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault()
                            })
                            .ToListAsync();
        }

       
    }
}
