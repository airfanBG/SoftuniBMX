namespace BicycleApp.Services.Models.Order
{    
    public class OrderDto
    {
        public string SerialNumber { get; set; } = null!;                
        public string ClientId { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal SaleAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal VAT { get; set; }
        public decimal FinalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal UnpaidAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int StatusId { get; set; }

    }
}
