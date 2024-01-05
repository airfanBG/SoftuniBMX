namespace BicycleApp.Services.Services.Orders
{
    using BicycleApp.Common.Providers.Contracts;

    using BicycleApp.Data;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.ApplicationGlobalConstants;

    public class OrderUserService : IOrderUserService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IStringManipulator _stringManipulator;
        private readonly IOrderFactory _orderFactory;
        private readonly IDateTimeProvider _dateTimeProvider;

        public OrderUserService(BicycleAppDbContext db,
                                IStringManipulator stringManipulator,
                                IOrderFactory orderFactory,
                                IDateTimeProvider dateTimeProvider)
        {
            _db = db;
            _stringManipulator = stringManipulator;
            _orderFactory = orderFactory;
            _dateTimeProvider = dateTimeProvider;
        }

        /// <summary>
        /// Creating order in database.
        /// </summary>
        /// <param name="order"></param>
        /// <returns>Task<int></returns>
        public IOrderPartsEmplyee? CreateOrderByUser(IUserOrderDto order)
        {
            try
            {
                var newOrder = new OrderDto();
                newOrder.ClientId = order.ClientId;
                newOrder.StatusId = 1;
                newOrder.OrderQuantity = order.OrderQuantity;

                decimal totalAmount = 0M;
                decimal totalDiscount = 0M;
                decimal totalVAT = 0M;

                var vatCategory =  _db.VATCategories.AsNoTracking().First(v => v.Id == order.VATId);

                foreach (var orderPart in order.OrderParts)
                {
                    var currentPart = _db.Parts.First(p => p.Id == orderPart.PartId);
                    decimal currentProductTotalPrice = Math.Round(currentPart.SalePrice * order.OrderQuantity, 2);
                    totalAmount += currentProductTotalPrice;
                    decimal currentProductTotalDiscount = Math.Round(currentPart.Discount * order.OrderQuantity, 2);
                    totalDiscount += currentProductTotalDiscount;
                    if (currentProductTotalDiscount > currentProductTotalPrice)
                    {
                        return null;
                    }
                    totalVAT += Math.Round(((currentProductTotalPrice - currentProductTotalDiscount) * vatCategory.VATPercent) / (100 + vatCategory.VATPercent), 2);
                    decimal productPrice = currentPart.SalePrice - currentPart.Discount;
                    var currentOrderPartToSave =  _orderFactory.CreateOrderPartFromUserOrder(currentPart.Name, 1, orderPart.PartId, productPrice);
                    newOrder.OrderParts.Add(currentOrderPartToSave);
                }

                newOrder.Discount = totalDiscount;
                newOrder.FinalAmount = totalAmount - totalDiscount;
                newOrder.VAT = totalVAT;
                newOrder.Description = _stringManipulator.GetTextFromProperty(order.Description);
                newOrder.SaleAmount = totalAmount - totalDiscount - totalVAT;

                var client = _db.Clients.First(c => c.Id == order.ClientId);

                var isThereEnoughMoney = CheckBalance(client.Balance, newOrder.FinalAmount);

                if (!isThereEnoughMoney)
                {
                    return null;
                }

                var newOrderObject =  _orderFactory.CreateUserOrder(newOrder, _dateTimeProvider.Now);

                if (newOrderObject != null)
                {
                     _db.Orders.Add(newOrderObject);
                     _db.SaveChanges();

                    newOrder.OrderId = newOrderObject.Id;

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
                                                   PartId = ope.PartId,
                                                   StartDate = ope.StartDatetime.ToString(),
                                                   EndDate = ope.EndDatetime.ToString(),
                                               }).ToList()
                            })
                            .ToListAsync();

        }

        /// <summary>
        /// Create order in OrdersPartsEmployee for future processing.
        /// </summary>
        /// <param name="newOrder"></param>
        /// <returns>Task<bool></returns>
        public bool CreateOrderPartEmployeeByUserOrder(IOrderPartsEmplyee newOrder)
        {
            try
            {    
                int quntityOfPart = newOrder.OrderQuantity;

                for (int i = 0; i < quntityOfPart; i++)
                {
                    string serialNumber =  _stringManipulator.SerialNumberGenerator();
                    string guidKey =  _stringManipulator.CreateGuid();

                    foreach (var orderPart in newOrder.OrderParts)
                    {
                        var ope = _orderFactory.CreateOrderPartEmployeeProduct(newOrder.OrderId, guidKey, serialNumber, orderPart.PartId, orderPart.PartName, orderPart.PartQuantity, orderPart.PartPrice, _dateTimeProvider.Now);

                        _db.OrdersPartsEmployees.Add(ope);
                    }
                }

                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        /// <summary>
        /// All orders made by user which are not started manifacturing.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<ICollection<OrderProgretionDto>> AllPendingApprovalOrder(string userId)
        {
            return await _db.Orders
                            .Where(o => o.ClientId == userId && o.DateUpdated.Equals(null))
                            .Select(o => new OrderProgretionDto()
                            {
                                DateCreated = o.DateCreated.ToString(DefaultDateFormat),
                                OrderId = o.Id
                            })
                            .ToListAsync();
        }

        /// <summary>
        /// Return order detail if order is successful.
        /// </summary>
        /// <param name="successOrder"></param>
        /// <returns>ISuccessOrderInfo</returns>
        public ISuccessOrderInfo SuccessCreatedOrder(IOrderPartsEmplyee successOrder)
        {
            var successOrderItems = _orderFactory.CreateSuccessOrderItems(successOrder);

            return successOrderItems;
        }

        /// <summary>
        /// Order is deleted by user selection.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="orderId"></param>
        /// <returns>Task</returns>
        public async Task DeleteOrder(string userId, int orderId)
        {
            var orderToDelete = await _db.Orders.FirstOrDefaultAsync(o => o.ClientId == userId && o.Id == orderId && o.StatusId == 1);

            if (orderToDelete != null)
            {
                orderToDelete.IsDeleted = true;
                orderToDelete.DateDeleted = _dateTimeProvider.Now;

                await _db.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Check and reduce client`s balance by needed amount for order. If it`s successful return <see langword="true"/>, otherwise <see langword="false"/>.    
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="percentageOfDeduction"></param>
        /// <param name="newOrder"></param>
        /// <returns>Task<bool></returns>
        public async Task<bool> DeductionByAmount(string clientId, decimal percentageOfDeduction, IOrder newOrder)
        {
            try
            {
                var client = await _db.Clients.FirstAsync(c => c.Id == clientId);

                decimal neededMoneyForOrder = Math.Round(newOrder.FinalAmount * (percentageOfDeduction / 100));

                client.Balance -= neededMoneyForOrder;

                var order = await _db.Orders.FirstAsync(o => o.Id == newOrder.OrderId);
                order.PaidAmount = neededMoneyForOrder;
                order.UnpaidAmount = newOrder.FinalAmount - neededMoneyForOrder;

                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }

            return false;
        }

        private bool CheckBalance(decimal clientBalanceAmount, decimal orderAmount)
        {
            if (clientBalanceAmount >= orderAmount)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Collection of all client orders with a specific status
        /// </summary>
        /// <param name="userId">Client Id</param>
        /// <returns>Collection of models</returns>
        /// <exception cref="ArgumentNullException">If userIs is null</exception>
        public async Task<ICollection<OrderClientShortInfo>> GetAllOrdersForClientByStatus(string userId, int status)
        {
            if (userId == null)
            {
                throw new ArgumentNullException();
            }

            var orders = await _db.Orders
                .Include(o => o.OrdersPartsEmployees)
                .ThenInclude(p => p.Part)
                .Where(o => o.ClientId == userId && o.StatusId == status)
                .OrderByDescending(o => o.DateCreated)
                .Select(r => new OrderClientShortInfo()
                {
                    OrderId = r.Id,
                    OrderDate = r.DateCreated.ToString(DefaultDateFormat),
                    Amount = r.FinalAmount,
                    SerialNumber = r.OrdersPartsEmployees.First().SerialNumber,
                    Parts = r.OrdersPartsEmployees
                    .Select(pa => new PartShortInfoDto()
                    {
                        Id = pa.PartId,
                        Name = pa.PartName
                    })
                    .ToList()
                })
                .ToListAsync();

            return orders;
        }

        /// <summary>
        /// Retusnt info abouth a client order
        /// </summary>
        /// <param name="orderId">Id of the order</param>
        /// <returns>Dto</returns>
        public async Task<OrderDtoInfo?> GetOrderById(int orderId)
        {
            var order = await _db.Orders
                .Where(o => o.Id == orderId)
                .Select(o => new OrderDtoInfo()
                {
                    SerialNumber = _db.OrdersPartsEmployees
                    .Where(op => op.OrderId == orderId)
                    .Select(op => op.SerialNumber)
                    .First(),
                    Description = o.Description,
                    FinalAmount = $"{o.FinalAmount:f2}",
                    UnpaidAmount = $"{o.UnpaidAmount:f2}",
                    Status = o.Status.Name,
                    DateCreated = o.DateCreated.ToString(DefaultDateFormat),
                    DateFinished = o.DateFinish != null ? o.DateFinish.Value.ToString(DefaultDateFormat) : "in progres"
                })
                .FirstOrDefaultAsync();

            if (order == null)
            {
                return null;
            }

            return order;

        }
    }
}
