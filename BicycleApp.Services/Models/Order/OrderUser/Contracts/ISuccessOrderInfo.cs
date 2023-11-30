namespace BicycleApp.Services.Models.Order.OrderUser.Contracts
{
    public interface ISuccessOrderInfo
    {
        public int OrderId { get; set; }
        public string ClientId { get; set; }
        public string Description { get; set; }
        public decimal SaleAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal VAT { get; set; }
        public decimal FinalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal UnpaidAmount { get; set; }
        public ICollection<OrderPartDto> OrderParts { get; set; }
    }
}
