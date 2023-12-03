namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

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

        [JsonPropertyName("vat")]
        public decimal VAT { get; set; }

        public decimal FinalAmount { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal UnpaidAmount { get; set; }

        [JsonPropertyName("parts")]
        public ICollection<OrderPartDto> OrderParts { get; set; }
    }
}
