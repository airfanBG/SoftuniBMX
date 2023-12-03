namespace BicycleApp.Services.Models.Order.OrderUser
{
    using System.Text.Json.Serialization;

    public class OrderProgretionDto
    {
        [JsonPropertyName("orderId")]
        public int OrderId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string DateCreated { get; set; } = null!;
        public ICollection<OrderStateDto> OrderStates { get; set; } = new List<OrderStateDto>();
    }
}
