namespace BicycleApp.Services.Services.Order
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Models.Order.OrderManager;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrderManagerService : IOrderManagerService
    {
        private readonly BicycleAppDbContext _db;
        private readonly IStringManipulator _stringManipulator;
        private readonly IDateTimeProvider _dateTimeProvider;
        public OrderManagerService(BicycleAppDbContext db,
                                   IStringManipulator stringManipulator,
                                   IDateTimeProvider dateTimeProvider)
        {
            _db = db;
            _stringManipulator = stringManipulator;
            _dateTimeProvider = dateTimeProvider;
        }
        

        /// <summary>
        /// Manager accept order and assign it to employee.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Task<bool></returns>
        public async Task<int> AcceptAndAssignOrderByManagerAsync(int orderId)
        {
            try
            {
                var orderPartsEmployees = await _db.OrdersPartsEmployees.Where(o => o.OrderId == orderId
                                                                                    && o.DatetimeAsigned == null)
                                                                        .ToListAsync();
                foreach (var orderPartEmployee in orderPartsEmployees)
                {
                    var аvailableParts = await _db.Parts.FirstAsync(p => p.Id == orderPartEmployee.PartId);
                    //Checks for available quantity
                    if (orderPartEmployee.PartQuantity > аvailableParts.Quantity)
                    {
                        return 0;
                    }
                    orderPartEmployee.DatetimeAsigned = _dateTimeProvider.Now;
                    аvailableParts.Quantity -= orderPartEmployee.PartQuantity;
                    orderPartEmployee.EmployeeId = await SetEmployeeToPart(orderPartEmployee.PartId);
                }

                var order = await _db.Orders.FirstAsync(o => o.Id == orderId);
                order.DateUpdated = _dateTimeProvider.Now;
                order.StatusId++;

                await _db.SaveChangesAsync();

                return orderId;
            }
            catch (Exception)
            {
            }
            return 0;
        }

        /// <summary>
        /// Return orders, where all waiting for a manager approvement.
        /// </summary>
        /// <returns>Task<ICollection<OrderInfoDto>></returns>
        public async Task<OrderQueryDto> AllPendingOrdersAsync(int currentPage)
        {
            int deliveriesPerPage = 6;

            var result = new OrderQueryDto();

            result.Orders =  await _db.Orders
                   .AsNoTracking()
                   .Where(o => o.OrdersPartsEmployees.Any(ope => ope.EmployeeId == null)
                                                                 && (o.IsDeleted == false && o.DateDeleted.Equals(null)))
                   .Skip((currentPage - 1) * deliveriesPerPage)
                   .Take(deliveriesPerPage)
                   .Select(ope => new OrderInfoDto
                   {
                       OrderId = ope.Id,
                       SerialNumber = ope.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                       DateCreated = ope.DateCreated.ToString(),
                       OrderParts = ope.OrdersPartsEmployees
                                   .Select(orderPart => new OrderPartInfoDto
                                   {
                                       PartId = orderPart.PartId,
                                       Description = _stringManipulator.GetTextFromProperty(orderPart.Description),
                                       PartName = orderPart.PartName,
                                       PartQuantity = orderPart.PartQuantity,
                                       PartQunatityInStock = orderPart.Part.Quantity
                                   })
                                   .ToList()
                   })
                   .ToListAsync();

            result.TotalOrdersCount = await _db.Orders
                   .AsNoTracking()
                   .Where(o => o.OrdersPartsEmployees.Any(ope => ope.EmployeeId == null)
                                                                 && (o.IsDeleted == false && o.DateDeleted.Equals(null)))
                   .CountAsync();

            return result;
        }

        /// <summary>
        /// Return orders, where all parts are assign to employee.
        /// </summary>
        /// <returns>Task<ICollection<OrderInfoDto>></returns>
        public async Task<ICollection<OrderInfoDto>> AllOrdersInProgressAsync()
        {
            var listOfPendingOrders = await _db.Orders
                                .AsNoTracking()
                                .Where(o => o.OrdersPartsEmployees.Any(ope => ope.EmployeeId != null
                                                                              && ope.DatetimeAsigned != null)
                                                                              && (o.IsDeleted == false && o.DateDeleted.Equals(null)))
                                .Select(ope => new OrderInfoDto
                                {
                                    OrderId = ope.Id,
                                    SerialNumber = ope.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                                    DateCreated = ope.DateCreated.ToString(),
                                    Department = ope.OrdersPartsEmployees.Select(ed=>ed.Employee.Department.Name).First(),
                                    EmployeeName = ope.OrdersPartsEmployees.Select(en => en.Employee.LastName).First(),
                                    OrderParts = ope.OrdersPartsEmployees
                                                .Select(orderPart => new OrderPartInfoDto
                                                {
                                                    PartId = orderPart.PartId,
                                                    Description = _stringManipulator.GetTextFromProperty(orderPart.Description),
                                                    PartName = orderPart.PartName,
                                                    CategoryName = orderPart.Part.Category.Name,
                                                    OemNumber = orderPart.Part.OEMNumber,
                                                    PartQuantity = orderPart.PartQuantity,
                                                    PartQunatityInStock = orderPart.Part.Quantity,
                                                    StartDate = orderPart.StartDatetime.ToString(),
                                                    EndDate = orderPart.EndDatetime.ToString(),
                                                    IsComplete = orderPart.IsCompleted
                                                })
                                                .ToList()
                                })
                                .ToListAsync();

            return listOfPendingOrders;
        }
        /// <summary>
        /// Check for available parts in store for current order.
        /// </summary>
        /// <param name="partsInOrder"></param>
        /// <param name="partInStockId"></param>
        /// <returns>Task<int></returns>
        public async Task<int> ArePartsNeeded(int partsInOrder, int partInStockId)
        {
            try
            {
                var аvailableParts = await _db.Parts
                                              .AsNoTracking()
                                              .FirstAsync(p => p.Id == partInStockId);

                int quantityOfPartInStock = (int)аvailableParts.Quantity;

                int partsNeeded = partsInOrder - quantityOfPartInStock;

                return partsNeeded;
                }
            catch (Exception ex)
            {
                throw new ApplicationException("Database can't retrive data", ex);
            }

        }

        /// <summary>
        /// Get orders in specific period.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>Task<ICollection<OrderInfoDto>></returns>
        public async Task<ICollection<OrderInfoDto>> GetAllFinishedOrdersForPeriod(FinishedOrdersDto datesPeriod)
        {
            var result =  await _db.Orders
                            .AsNoTracking()
                            .Where(o => o.DateCreated >= datesPeriod.StartDate
                                     && o.DateFinish <= datesPeriod.EndDate)
                            .Select(o => new OrderInfoDto()
                            {
                                OrderId = o.Id,
                                SerialNumber = o.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                                DateCreated = o.DateCreated.ToString(),
                                DateFinished = o.DateFinish.ToString(),
                                OrderParts = o.OrdersPartsEmployees
                                                .Select(orderPart => new OrderPartInfoDto
                                                {
                                                    PartId = orderPart.PartId,
                                                    Description = _stringManipulator.GetTextFromProperty(orderPart.Description),
                                                    PartName = orderPart.PartName,
                                                    PartQuantity = orderPart.PartQuantity,
                                                    PartQunatityInStock = orderPart.Part.Quantity
                                                })
                                                .ToList()

                            })

                            .ToListAsync();

            return result;
        }

        /// <summary>
        /// Manager set isDeleted proeprty to true and DateDeleted property is filled.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Task</returns>
        public async Task<int> ManagerDeleteOrder(int orderId)
        {
            if (orderId <= 0)
            {
                throw new ArgumentNullException(nameof(orderId));
            }

            try
            {
                var orderToReject = await _db.Orders.FirstAsync(o => o.Id == orderId);
                orderToReject.DateDeleted = _dateTimeProvider.Now;
                orderToReject.IsDeleted = true;

                _db.Orders.Update(orderToReject);
                await _db.SaveChangesAsync();

                return orderId;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Database can't retrive data", ex);
            }
        }

        /// <summary>
        /// The method checks for available parts, Sets EmployeeId only to available part and return collection of partsForPurchase
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Task<ICollection<OrderPartDeliveryDto>> - the parts for purchaise</returns>
        public async Task<ICollection<OrderPartDeliveryDto>> RejectOrderAsync(int orderId)
        {
            var partsForPurchase = new List<OrderPartDeliveryDto>();

            try
            {
                var orderPartsEmployees = await _db.OrdersPartsEmployees.Where(o => o.OrderId == orderId
                                                                                    && o.DatetimeAsigned == null)
                                                                        .ToListAsync();
                foreach (var orderPartEmployee in orderPartsEmployees)
                {

                    int arePartsNeeded = await ArePartsNeeded(orderPartEmployee.PartQuantity, orderPartEmployee.PartId);

                    //Checks for available quantity
                    if (arePartsNeeded > 0)
                    {
                        var partForPurchase = new OrderPartDeliveryDto
                        {
                            PartId = orderPartEmployee.PartId,
                            Name = orderPartEmployee.PartName,
                            Note = string.Empty,
                            NeededQuantity = arePartsNeeded
                        };

                        partsForPurchase.Add(partForPurchase);
                    }

                    orderPartEmployee.EmployeeId = await SetEmployeeToPart(orderPartEmployee.PartId);
                }

                await _db.SaveChangesAsync();

                return partsForPurchase;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Database can't retrive data", ex);
            }
            }

        /// <summary>
        /// The method returns all rejected orders (painding for a part delivery)
        /// </summary>
        /// <returns>Task<ICollection<OrderInfoDto>>- the Rejected Orders (painding for a part delivery or payment)</returns>
        public async Task<ICollection<OrderInfoDto>> AllRejectedOrdersAsync()
        {
            var listOfPendingOrders = await _db.Orders
                                .AsNoTracking()
                                .Where(o => o.OrdersPartsEmployees.Any(ope => ope.EmployeeId != null && ope.DatetimeAsigned == null)
                                                                              && (o.IsDeleted == false
                                                                              && o.DateDeleted.Equals(null)))
                                .Select(ope => new OrderInfoDto
                                {
                                    OrderId = ope.Id,
                                    SerialNumber = ope.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                                    DateCreated = ope.DateCreated.ToString(),
                                    OrderParts = ope.OrdersPartsEmployees
                                                .Select(orderPart => new OrderPartInfoDto
                                                {
                                                    PartId = orderPart.PartId,
                                                    Description = _stringManipulator.GetTextFromProperty(orderPart.Description),
                                                    PartName = orderPart.PartName,
                                                    PartQuantity = orderPart.PartQuantity,
                                                    PartQunatityInStock = orderPart.Part.Quantity
                                                })
                                                .ToList()
                                })
                                .ToListAsync();

            return listOfPendingOrders;
        }

        /// <summary>
        /// The method sets employee to appropriate part
        /// </summary>
        /// <param name="partId"></param>
        /// <returns>Task<string></returns>
        public async Task<string> SetEmployeeToPart(int partId)
        {
            try
            {
                var part = await _db.Parts
                    .Include(pc => pc.Category)
                    .FirstAsync(p => p.Id == partId);

                var partType = part.Category.Name;

                if (partType.ToLower() == "frame")
                {
                    var employee = await _db.Employees.FirstAsync(e => e.Position == "FrameWorker");
                    return employee.Id;
                }
                else if (partType.ToLower() == "wheel")
                {
                    var employee = await _db.Employees.FirstAsync(e => e.Position == "Wheelworker");
                    return employee.Id;
                }
                else if (partType.ToLower() == "acsessories")
                {
                    var employee = await _db.Employees.FirstAsync(e => e.Position == "Accessoriesworker");
                    return employee.Id;
                }
            }
            catch (Exception)
            {
            }
            return string.Empty;
        }

        /// <summary>
        /// Manager accept rejected order and assign it to employee.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Task<bool></returns>
        public async Task<bool> AcceptAndAssignRejectedOrderByManagerAsync(int orderId)
        {
            try
            {
                var orderPartsEmployees = await _db.OrdersPartsEmployees.Where(o => o.OrderId == orderId
                                                                                    && o.DatetimeAsigned == null)
                                                                        .ToListAsync();

                foreach (var orderPartEmployee in orderPartsEmployees)
                {

                    int arePartsNeeded = await ArePartsNeeded(orderPartEmployee.PartQuantity, orderPartEmployee.PartId);

                    //Checks for available quantity
                    if (arePartsNeeded > 0)
                    {
                        return false;
                    }
                    orderPartEmployee.DatetimeAsigned = _dateTimeProvider.Now;
                    var аvailableParts = await _db.Parts.FirstAsync(p => p.Id == orderPartEmployee.PartId);
                    аvailableParts.Quantity -= orderPartEmployee.PartQuantity;
                }

                var order = await _db.Orders.FirstAsync(o => o.Id == orderId);
                order.DateUpdated = _dateTimeProvider.Now;

                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public async Task<AllEmployeesDto?> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
