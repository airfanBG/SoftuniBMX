namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using System.Collections.Generic;

    public class SuccessOrderInfo : ISuccessOrderInfo
    {
        public SuccessOrderInfo()
        {
            this.OrderParts = new List<OrderPartDto>();
        }
        public int OrderId { get; set; }
        public string ClientId { get; set; } = null!;
        public string? Description { get; set; } 
        public decimal SaleAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal VAT { get; set; }
        public decimal FinalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal UnpaidAmount { get; set; }
        public ICollection<OrderPartDto> OrderParts { get; set; }
    }
}
