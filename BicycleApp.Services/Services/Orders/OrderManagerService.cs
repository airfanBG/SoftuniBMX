namespace BicycleApp.Services.Services.Order
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.HelperClasses.Contracts;
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
        public async Task<bool> AcceptAndAssignOrderByManagerAsync(int orderId)
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
                    orderPartEmployee.EmployeeId = await SetEmployeeToPart(orderPartEmployee.PartId);
                }

                var order = await _db.Orders.FirstAsync(o => o.Id == orderId);
                order.DateUpdated = _dateTimeProvider.Now;
                order.StatusId++;

                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        /// <summary>
        /// Return orders, where all waiting for a manager approvement.
        /// </summary>
        /// <returns>Task<ICollection<OrderInfoDto>></returns>
        public async Task<ICollection<OrderInfoDto>> AllPendingOrdersAsync()
        {
            var listOfPendingOrders = await _db.Orders
                                .AsNoTracking()
                                .Where(o => o.OrdersPartsEmployees.Any(ope => ope.EmployeeId == null)
                                                                              && (o.IsDeleted == false && o.DateDeleted.Equals(null)))
                                .Select(ope => new OrderInfoDto
                                {
                                    Id = ope.Id,
                                    SerialNumber = ope.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                                    OrderParts = ope.OrdersPartsEmployees
                                                .Select(orderPart => new OrderPartInfoDto
                                                {
                                                    PartId = orderPart.PartId,
                                                    Descrioption = _stringManipulator.GetTextFromProperty(orderPart.Description),
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
                                    Id = ope.Id,
                                    SerialNumber = ope.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                                    OrderParts = ope.OrdersPartsEmployees
                                                .Select(orderPart => new OrderPartInfoDto
                                                {
                                                    PartId = orderPart.PartId,
                                                    Descrioption = _stringManipulator.GetTextFromProperty(orderPart.Description),
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

        ///// <summary>
        ///// Change status of existing order.
        ///// </summary>
        ///// <param name="orderId"></param>
        ///// <param name="newStatusId"></param>
        ///// <returns>Task<bool></returns>
        //public async Task<bool> ChangeStatus(int orderId, int newStatusId)
        //{
        //    try
        //    {
        //        var order = await _db.Orders.FirstAsync(o => o.Id == orderId);
        //        order.StatusId = newStatusId;
        //        order.DateUpdated = DateTime.UtcNow;

        //        _db.Orders.Update(order);
        //        await _db.SaveChangesAsync();

        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    return false;
        //}
        //public async Task EmployeeEndProduction(string employeeId, int orderId, int partId)
        //{
        //    try
        //    {
        //        var finishedPart = await _db.OrdersPartsEmployees
        //                                .FirstAsync(ope => ope.EmployeeId == employeeId
        //                                                   && ope.OrderId == orderId
        //                                                   && ope.PartId == partId);

        //        finishedPart.EndDatetime = DateTime.UtcNow;
        //        finishedPart.IsCompleted = true;

        //        _db.OrdersPartsEmployees.Update(finishedPart);
        //        await _db.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
        //public async Task EmployeeStartProduction(string employeeId, int orderId, int partId)
        //{
        //    try
        //    {
        //        var finishedPart = await _db.OrdersPartsEmployees
        //                                .FirstAsync(ope => ope.EmployeeId == employeeId
        //                                                   && ope.OrderId == orderId
        //                                                   && ope.PartId == partId);

        //        finishedPart.StartDatetime = DateTime.UtcNow;

        //        _db.OrdersPartsEmployees.Update(finishedPart);
        //        await _db.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        //public async Task<ICollection<EmployeePartTaskDto>> EmployeeUnfinishedTask(string employeeId)
        //{
        //    var listOfTask = await _db.OrdersPartsEmployees
        //                              .AsNoTracking()
        //                              .Where(ope => ope.EmployeeId == employeeId && ope.EndDatetime == null && ope.IsCompleted == false)
        //                              .Select(ope => new EmployeePartTaskDto
        //                              {
        //                                  PartName = ope.Part.Name
        //                              })
        //                              .ToListAsync();
        //    return listOfTask;
        //}

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
                                Id = o.Id,
                                SerialNumber = o.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault()
                            })
                            .ToListAsync();

            return result;
        }

        /// <summary>
        /// Manager set isDeleted proeprty to true and DateDeleted property is filled.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Task</returns>
        public async Task ManagerDeleteOrder(int orderId)
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
                                    Id = ope.Id,
                                    SerialNumber = ope.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                                    OrderParts = ope.OrdersPartsEmployees
                                                .Select(orderPart => new OrderPartInfoDto
                                                {
                                                    PartId = orderPart.PartId,
                                                    Descrioption = _stringManipulator.GetTextFromProperty(orderPart.Description),
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
       
    }
}
