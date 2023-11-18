namespace BicycleApp.Services.Services.Orders
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.Models.Order;
    using Microsoft.EntityFrameworkCore;
    using System.Text;

    public class OrderUserService : IOrderUserService
    {
        private readonly BicycleAppDbContext _db;
        public OrderUserService(BicycleAppDbContext db)
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

                var orderToSave = new Order()
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
                    var ope = new OrderPartEmployee()
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
