namespace BicycleApp.Services.Services.Order
{
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Order;
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using BicycleApp.Data.Models.EntityModels;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class OrderService : IOrderService
    {
        private readonly BicycleAppDbContext _db;
        public OrderService(BicycleAppDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Creating order in database.
        /// </summary>
        /// <param name="order"></param>
        /// <returns>Task<bool></returns>
        public async Task<bool> CreateOrderByUserAsync(OrderDto order)
        {
            try
            {
                string serialNumber = SerialNumberGenerator();

                Order orderToSave = new Order()
                {
                    ClientId = order.ClientId,
                    DateCreated = DateTime.UtcNow,
                    Description = string.IsNullOrEmpty(order.Description) ? string.Empty : order.Description,
                    SerialNumber = serialNumber,
                    StatusId = 1
                };

                decimal totalAmount = 0M;
                decimal totalDiscount = 0M;
                decimal totalVAT = 0M;

                var vatCategory = await _db.VATCategories.AsNoTracking().FirstAsync(v => v.Id == order.VATId);

                foreach (var orderPart in order.OrderParts)
                {
                    decimal currentProductTotalPrice = Math.Round(orderPart.PricePerUnit * orderPart.Quantity, 2);
                    totalAmount += currentProductTotalPrice;
                    decimal currentProductTotalDiscount = Math.Round(orderPart.Discount * orderPart.Quantity, 2);
                    totalDiscount += currentProductTotalDiscount;
                    if (currentProductTotalDiscount > currentProductTotalPrice)
                    {
                        return false;
                    }
                    totalVAT += Math.Round(((currentProductTotalPrice - currentProductTotalDiscount) * vatCategory.VATPercent) / (100 + vatCategory.VATPercent), 2);
                }

                orderToSave.Discount = totalDiscount;
                orderToSave.FinalAmount = totalAmount - totalDiscount;
                orderToSave.VAT = totalVAT;
                orderToSave.SaleAmount = totalAmount - totalDiscount - totalVAT;

                await _db.Orders.AddAsync(orderToSave);
                await _db.SaveChangesAsync();

                ICollection<OrderPartEmployee> orderPartEmployeeCollection = new List<OrderPartEmployee>();

                foreach (var part in order.OrderParts)
                {
                    OrderPartEmployee ope = new OrderPartEmployee()
                    {
                        OrderId = orderToSave.Id,
                        PartId = part.PartId,
                        PartPrice = part.PricePerUnit,
                        PartQuantity = part.Quantity,
                        PartName = part.PartName,
                        Description = string.IsNullOrEmpty(order.Description) ? string.Empty : order.Description
                    };

                    orderPartEmployeeCollection.Add(ope);
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

        /// <summary>
        /// Manager accept order and assign it to employee.
        /// </summary>
        /// <param name="managerApprovalDto"></param>
        /// <returns>Task<bool></returns>
        public async Task<bool> AcceptAndAssignOrderByManagerAsync(ManagerApprovalDto managerApprovalDto)
        {
            try
            {
                var orderPartToEmployee = await _db.OrdersPartsEmployees
                                                   .FirstAsync(ope => ope.OrderId == managerApprovalDto.OrderId
                                                                      && ope.PartId == managerApprovalDto.OrderParts.PartId
                                                                      && ope.EmployeeId == null);

                bool areAvailableParts = await ArePartsAvailable(managerApprovalDto.OrderParts.Quantity, managerApprovalDto.OrderParts.PartId);
                //Checks for available quantity
                if (!areAvailableParts)
                {
                    return false;
                }

                orderPartToEmployee.EmployeeId = managerApprovalDto.EmployeeId;
                orderPartToEmployee.DatetimeAsigned = DateTime.UtcNow;

                var аvailableParts = await _db.Parts.FirstAsync(p => p.Id == managerApprovalDto.OrderParts.PartId);
                аvailableParts.Quantity -= managerApprovalDto.OrderParts.Quantity;

                var order = await _db.Orders.FirstAsync(o => o.Id == managerApprovalDto.OrderId);
                order.DateUpdated = DateTime.UtcNow;

                _db.Orders.Update(order);
                _db.OrdersPartsEmployees.Update(orderPartToEmployee);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        /// <summary>
        /// Return order, where all parts are assign to employee.
        /// </summary>
        /// <returns>Task<ICollection<OrderInfoDto>></returns>
        public async Task<ICollection<OrderInfoDto>> AllPendingOrdersAsync()
        {
            var listOfPendingOrders = await _db.Orders
                                .Where(o => o.OrdersPartsEmployees.Any(ope => ope.EmployeeId == null)
                                                                              && (o.IsDeleted == false && o.DateDeleted.Equals(null)))
                                .Select(ope => new OrderInfoDto
                                {
                                    OrderId = ope.Id,
                                    SerialNumber = ope.SerialNumber,
                                    OrderParts = ope.OrdersPartsEmployees
                                                .Select(orderPart => new OrderPartDto
                                                {
                                                    PartId = orderPart.PartId,
                                                    Description = string.IsNullOrEmpty(orderPart.Description) ? string.Empty : orderPart.Description,
                                                    Discount = ope.Discount,
                                                    PartName = orderPart.PartName,
                                                    PricePerUnit = orderPart.PartPrice,
                                                    Quantity = orderPart.PartQuantity
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
        /// <returns>Task<bool></returns>
        public async Task<bool> ArePartsAvailable(int partsInOrder, int partInStockId)
        {
            try
            {
                var аvailableParts = await _db.Parts
                                              .AsNoTracking()
                                              .FirstAsync(p => p.Id == partInStockId);
                int quantityOfPartInStock = (int)аvailableParts.Quantity;

                if (quantityOfPartInStock >= partsInOrder)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            return false;
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
        /// <returns>Task</returns>
        public async Task<ICollection<OrderInfoDto>> GetAllFinishedOrdersForPeriod(DateTime startDate, DateTime endDate)
        {
            return await _db.Orders
                            .AsNoTracking()
                            .Where(o => o.DateCreated >= startDate && o.DateFinish <= endDate)
                            .Select(o => new OrderInfoDto()
                            {
                                OrderId = o.Id,
                                SerialNumber = o.SerialNumber
                            })
                            .ToListAsync();
        }

        /// <summary>
        /// Manager set isDeleted proeprty to true and DateDeleted property is filled.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>Task</returns>
        public async Task ManagerOrderRejection(int orderId)
        {
            try
            {
                var orderToReject = await _db.Orders.FirstAsync(o => o.Id == orderId);
                orderToReject.DateDeleted = DateTime.UtcNow;
                orderToReject.IsDeleted = true;

                _db.Orders.Update(orderToReject);
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
            }

        }

        /// <summary>
        /// Generator of serial number.
        /// </summary>
        /// <returns>string</returns>
        private string SerialNumberGenerator()
        {
            StringBuilder serialNumber = new StringBuilder("BID");
            int numberOfrandoms = 7;

            string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            Random random = new Random();

            for (int i = 0; i <= numberOfrandoms; i++)
            {
                int randomCharIndex = random.Next(0, allowedChars.Length + 1);
                serialNumber.Append(allowedChars[randomCharIndex]);
            }

            return serialNumber.ToString();
        }
    }
}
