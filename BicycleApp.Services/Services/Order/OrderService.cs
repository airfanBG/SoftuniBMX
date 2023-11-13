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

    public class OrderService : IOrderService
    {
        private readonly BicycleAppDbContext _db;
        public OrderService(BicycleAppDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Manager accept order and manage it to employee.
        /// </summary>
        /// <param name="managerApprovalDto"></param>
        /// <returns>bool</returns>
        public async Task<bool> AcceptAndCreateOrderByManagerAsync(ManagerApprovalDto managerApprovalDto)
        {
            try
            {
                OrderPartEmployee orderPartToEmployee = new OrderPartEmployee();

                bool areAvailableParts = await ArePartsAvailable(managerApprovalDto.OrderParts.Quantity, managerApprovalDto.OrderParts.PartId);
                //Checks for available quantity
                if (!areAvailableParts)
                {
                    return false;
                }
                OrderPartEmployee ope = new OrderPartEmployee()
                {
                    EmployeeId = managerApprovalDto.EmployeeId,
                    OrderId = managerApprovalDto.OrderId,
                    PartId = managerApprovalDto.OrderParts.PartId,
                    Description = string.IsNullOrEmpty(managerApprovalDto.OrderParts.Description) ? string.Empty : managerApprovalDto.OrderParts.Description,
                    DatetimeAsigned = DateTime.UtcNow,
                };

                var аvailableParts = await _db.Parts.FirstAsync(p => p.Id == managerApprovalDto.OrderParts.PartId);
                аvailableParts.Quantity -= managerApprovalDto.OrderParts.Quantity;

                var order = await _db.Orders.FirstAsync(o => o.Id == managerApprovalDto.OrderId);
                order.DateUpdated = DateTime.UtcNow;

                _db.Orders.Update(order);
                await _db.OrdersPartsEmployees.AddAsync(orderPartToEmployee);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }


        public async Task<ICollection<OrderInfoDto>> AllPendingOrdersAsync(string managerId)
        {
            var listOfPendingOrders = await _db.Orders
                                         .Where(o => o.DateDeleted == null || (o.DateFinish == null && o.DateUpdated != null))
                                         .Select(o => new OrderInfoDto()
                                         {
                                             OrderId = o.Id,
                                             SerialNumber = o.SerialNumber
                                         })
                                         .ToListAsync();

            return listOfPendingOrders;
        }

        public async Task<bool> ArePartsAvailable(int partsInOrder, int partInStockId)
        {
            try
            {
                var аvailableParts = await _db.Parts.FirstAsync(p => p.Id == partInStockId);
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

        /// <summary>
        /// Assigning given part of chosen order to employee
        /// </summary>
        /// <param name="managerId"></param>
        /// <param name="employeeId"></param>
        /// <param name="orderId"></param>
        /// <param name="partId"></param>
        /// <returns></returns>
        public async Task AssigningOrderToEmployee(string managerId, string employeeId, int orderId, int partId)
        {
            try
            {
                var orderToAssign = await _db.OrdersPartsEmployees
                                         .FirstAsync(ope => ope.EmployeeId == managerId
                                                            && ope.OrderId == orderId
                                                            && ope.PartId == partId);

                orderToAssign.EmployeeId = employeeId;
                orderToAssign.DatetimeAsigned = DateTime.UtcNow;

                _db.OrdersPartsEmployees.Update(orderToAssign);
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
            }

        }

        /// <summary>
        /// Change status of existing order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="newStatusId"></param>
        /// <returns>bool</returns>
        public async Task<bool> ChangeStatus(int orderId, int newStatusId)
        {
            try
            {
                var order = await _db.Orders.FirstAsync(o => o.Id == orderId);
                order.StatusId = newStatusId;
                order.DateUpdated = DateTime.UtcNow;

                _db.Orders.Update(order);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
            }
            return false;
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

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        public async Task EmployeeEndProduction(string employeeId, int orderId, int partId)
        {
            try
            {
                var finishedPart = await _db.OrdersPartsEmployees
                                        .FirstAsync(ope => ope.EmployeeId == employeeId
                                                           && ope.OrderId == orderId
                                                           && ope.PartId == partId);

                finishedPart.EndDatetime = DateTime.UtcNow;
                finishedPart.IsCompleted = true;

                _db.OrdersPartsEmployees.Update(finishedPart);
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        public async Task EmployeeStartProduction(string employeeId, int orderId, int partId)
        {
            try
            {
                var finishedPart = await _db.OrdersPartsEmployees
                                        .FirstAsync(ope => ope.EmployeeId == employeeId
                                                           && ope.OrderId == orderId
                                                           && ope.PartId == partId);

                finishedPart.StartDatetime = DateTime.UtcNow;

                _db.OrdersPartsEmployees.Update(finishedPart);
                await _db.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        public async Task<ICollection<EmployeePartTaskDto>> EmployeeUnfinishedTask(string employeeId)
        {
            var listOfTask = await _db.OrdersPartsEmployees
                                      .Where(ope => ope.EmployeeId == employeeId && ope.EndDatetime == null && ope.IsCompleted == false)
                                      .Select(ope => new EmployeePartTaskDto
                                      {
                                          PartName = ope.Part.Name
                                      })
                                      .ToListAsync();
            return listOfTask;
        }

        public async Task<ICollection<OrderInfoDto>> GetAllFinishedOrdersForPeriod(DateTime startDate, DateTime endDate)
        {
            return await _db.Orders
                            .Where(o => o.DateCreated >= startDate && o.DateFinish <= endDate)
                            .Select(o => new OrderInfoDto()
                            {
                                OrderId = o.Id,
                                SerialNumber = o.SerialNumber
                            })
                            .ToListAsync();
        }

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
