namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using System.Text.Json.Serialization;

    public class OrderPartDto : IOrderPartDto
    {
        [JsonPropertyName("name")]
        public string PartName { get; set; } = null!;

        [JsonPropertyName("quantity")]
        public int PartQuantity { get; set; }

        [JsonPropertyName("partId")]
        public int PartId { get; set; }

        [JsonPropertyName("price")]
        public decimal PartPrice { get; set; }
    }
}
