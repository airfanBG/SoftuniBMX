namespace BicycleApp.Services.Models.Order.OrderManager
{
    using BicycleApp.Services.Models.IdentityModels;
    using System.Text.Json.Serialization;

    public class OrderSendedDto
    {
        [JsonPropertyName("orderId")]
        public int OrderId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public decimal SaleAmount { get; set; } 
        public string ClientName { get; set; } = null!;
        public string ClientEmail { get; set; } = null!;
        public string ClientPhone { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string SendDate { get; set; } = null!;
        public ClientAddressDto ClientAdress { get; set; } = null!;
    }
}