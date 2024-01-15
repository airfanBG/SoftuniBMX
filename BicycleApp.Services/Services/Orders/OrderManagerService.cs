namespace BicycleApp.Services.Services.Order
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.IdentityModels;
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Models.Order.OrderManager;
    using BicycleApp.Services.Models.Order.OrderUser;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using static BicycleApp.Common.ApplicationGlobalConstants;
    using static BicycleApp.Common.EntityValidationConstants;

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

            result.Orders = await _db.Orders
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

        public async Task<ICollection<OrderProgretionDto>> AllOrdersInProgressAsync()
        {
            try
            {
                return await _db.Orders
                           .Include(o => o.OrdersPartsEmployees)
                               .ThenInclude(ope => ope.Employee)
                           .Include(o => o.OrdersPartsEmployees)
                               .ThenInclude(ope => ope.Part)
                               .ThenInclude(part => part.Category)
                           .Include(o => o.OrdersPartsEmployees)
                           .ThenInclude(ope => ope.OrdersPartsEmployeesInfos)
                           .Where(o => o.OrdersPartsEmployees.Any(ope => ope.EmployeeId != null
                                                                             && ope.DatetimeAsigned != null)
                                                                             && (o.IsDeleted == false
                                                                             && o.DateDeleted.Equals(null))
                                                                             && o.DateFinish.Equals(null))
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
                                                  PartModel = ope.PartName,
                                                  PartType = ope.Part.Category.Name,
                                                  SerialNumber = ope.SerialNumber,
                                                  PartId = ope.PartId,
                                                  PartQuantity = ope.PartQuantity,
                                                  StartDate = ope.StartDatetime.ToString(),
                                                  EndDate = ope.EndDatetime.ToString(),
                                                  Description = ope.OrdersPartsEmployeesInfos.Where(o => ope.OrderId == o.OrderId && ope.PartId == o.PartId && ope.UniqueKeyForSerialNumber == o.UniqueKeyForSerialNumber).OrderBy(id => id.Id).LastOrDefault().DescriptionForWorker,
                                                  ElementProduceTimeInMinutes = ope.OrdersPartsEmployeesInfos.Where(opei => opei.OrderId == ope.OrderId
                                                           && opei.PartId == ope.PartId
                                                           && opei.UniqueKeyForSerialNumber == ope.UniqueKeyForSerialNumber)
                                                                                                    .Sum(opeis => opeis.ProductionТime.Minutes)
                                              }).ToList()
                           })
                           .ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
           

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
        public async Task<ICollection<OrderProgretionDto>> GetAllFinishedOrdersForPeriod(FinishedOrdersDto datesPeriod)
        {
            var result = await _db.Orders
                            .Include(o => o.OrdersPartsEmployees)
                            .ThenInclude(ope => ope.OrdersPartsEmployeesInfos)
                            .Include(o => o.Client)
                            .AsNoTracking()
                            .Where(o => o.DateCreated >= datesPeriod.StartDate
                                     && o.DateFinish <= datesPeriod.EndDate.AddDays(1)
                                     && o.DateFinish != null
                                     && o.DateSended == null
                                     && o.DateDeleted == null)
                            .Select(o => new OrderProgretionDto()
                            {
                                OrderId = o.Id,
                                SerialNumber = o.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                                DateCreated = o.DateCreated.ToString(DefaultDateFormat),
                                DateFinished = o.DateFinish.Value.ToString(DefaultDateFormat),
                                SaleAmount = o.FinalAmount,
                                ClientName = _stringManipulator.ReturnFullName(o.Client.FirstName, o.Client.LastName),
                                ClientEmail = o.Client.Email,
                                ClientPhone = o.Client.PhoneNumber,
                                PaidAmount = o.PaidAmount,
                                UnpaidAmount = o.UnpaidAmount,
                                FinalAmount = o.FinalAmount,
                                OrderStates = o.OrdersPartsEmployees
                                               .Select(ope => new OrderStateDto()
                                               {
                                                   IsProduced = ope.IsCompleted,
                                                   NameOfEmplоyeeProducedThePart = _stringManipulator.ReturnFullName(ope.Employee.FirstName, ope.Employee.LastName),
                                                   PartModel = ope.PartName,
                                                   PartType = ope.Part.Category.Name,
                                                   SerialNumber = ope.Part.OEMNumber,
                                                   PartId = ope.PartId,
                                                   PartQuantity = ope.PartQuantity,
                                                   StartDate = ope.StartDatetime.ToString(),
                                                   EndDate = ope.EndDatetime.ToString(),
                                                   Description = _stringManipulator.GetTextFromProperty(ope.Description),
                                                   ElementProduceTimeInMinutes = ope.OrdersPartsEmployeesInfos.Where(opei => opei.OrderId == ope.OrderId
                                                            && opei.PartId == ope.PartId
                                                            && opei.UniqueKeyForSerialNumber == ope.UniqueKeyForSerialNumber)
                                                                                                     .Sum(opeis => opeis.ProductionТime.Minutes)
                                               }).ToList()
                            })

                            .ToListAsync();

            foreach (var order in result)
            {
                order.TotalProductionTime = await GetTotalProductionTime(order.OrderId);
            }

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

        public async Task<ICollection<EmployeeInfoDto>> GetAllEmployees(string httpScheme, string httpHost, string httpPathBase)
        {
            return await _db.Employees
                            .AsNoTracking()
                            .Select(e => new EmployeeInfoDto()
                            {
                                DateCreated = e.DateCreated.ToString(DefaultDateFormat),
                                DateOfHire = e.DateOfHire.ToString(DefaultDateFormat),
                                DateOfLeave = e.DateOfLeave.ToString(),
                                DateUpdated = e.DateUpdated.ToString(),
                                Department = e.Department.Name,
                                Email = e.Email,
                                Id = e.Id,
                                FirstName = e.FirstName,
                                LastName = e.LastName,
                                IsManeger = e.IsManeger,
                                PhoneNumber = e.PhoneNumber,
                                Position = e.Position,
                                BaseSalary = e.BaseSalary,
                                ImageUrl = _stringManipulator.UrlImageMaker(httpScheme, httpHost, httpPathBase, e.ImagesEmployees.Select(e => e.ImageUrl).FirstOrDefault())

                            }).ToListAsync();

        }

        public async Task<int> GetTotalProductionTime(int orderId)
        {
            return await _db.OrdersPartsEmployeesInfos
                .Where(opei => opei.OrderId == orderId)
                .SumAsync(opei => opei.ProductionТime.Minutes);
        }

        public async Task<OrderQueryDto> AllDeletedOrdersAsync(int currentPage)
        {
            int deliveriesPerPage = 6;

            var result = new OrderQueryDto();

            result.Orders = await _db.Orders
                   .AsNoTracking()
                   .Where(o => o.DateDeleted != null && o.IsDeleted == true)
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
                   .Where(o => o.DateDeleted != null && o.IsDeleted == true)
                   .CountAsync();

            return result;
        }

        /// <summary>
        /// Gets all sended orders.
        /// </summary>
        /// <returns>Task<ICollection<OrderSendedDto>></returns>
        public async Task<ICollection<OrderSendedDto>> AllSendedOrdersAsync()
        {
            return await _db.Orders
                            .Include(o => o.OrdersPartsEmployees)
                            .ThenInclude(ope => ope.OrdersPartsEmployeesInfos)
                            .Include(o => o.Client)
                            .AsNoTracking()
                            .Where(o => o.DateFinish != null
                                     && o.DateSended != null
                                     && o.DateDeleted == null)
                            .Select(o => new OrderSendedDto()
                            {
                                OrderId = o.Id,
                                SerialNumber = o.OrdersPartsEmployees.Select(sn => sn.SerialNumber).FirstOrDefault(),
                                SaleAmount = o.FinalAmount,
                                ClientName = _stringManipulator.ReturnFullName(o.Client.FirstName, o.Client.LastName),
                                ClientEmail = o.Client.Email,
                                ClientPhone = o.Client.PhoneNumber,
                                SendDate = _stringManipulator.GetTextFromProperty(o.DateSended.Value.ToString(DefaultDateFormat)),
                                ImageUrl = _db.BikesStandartModels.Select(b => b.ImageUrl).FirstOrDefault(),
                                ClientAdress = new ClientAddressDto
                                {
                                    Street = o.Client.DelivaryAddress.Street,
                                    StrNumber = o.Client.DelivaryAddress.StrNumber,
                                    Apartment = o.Client.DelivaryAddress.Apartment,
                                    Block = o.Client.DelivaryAddress.Block,
                                    Country = o.Client.DelivaryAddress.Country,
                                    District = o.Client.DelivaryAddress.District,
                                    Floor = o.Client.DelivaryAddress.Floor,
                                    PostCode = o.Client.DelivaryAddress.PostCode
                                }
                            })
                            .ToListAsync();
        }

        public async Task<bool> SendOrderAsync(int orderId)
        {
            try
            {
                var orderForSend = await _db.Orders.Where(o => o.Id == orderId
                                                                        && o.DateFinish != null
                                                                        && o.DateDeleted == null)
                                                                        .FirstAsync();

                orderForSend.DateSended = _dateTimeProvider.Now;
                orderForSend.StatusId++;

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
