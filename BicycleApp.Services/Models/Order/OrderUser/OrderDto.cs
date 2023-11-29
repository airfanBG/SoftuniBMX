namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using System;
    using System.Collections.Generic;

    public class OrderDto : IOrderPartsEmplyee
    {
        public int OrderId { get; set ; }
        public string ClientId { get; set; } = null!;
        public string Description { get; set; }
        public decimal SaleAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal VAT { get; set; }
        public decimal FinalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal UnpaidAmount { get; set; }
        public DateTime? DateFinish { get; set; }
        public bool IsDeleted { get; set; }
        public int StatusId { get; set; }
        public ICollection<IOrderPartDto> OrderParts { get; set; } = new List<IOrderPartDto>();
       
    }
}
