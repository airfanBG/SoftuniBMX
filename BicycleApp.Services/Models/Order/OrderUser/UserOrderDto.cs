namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class UserOrderDto : IUserOrderDto
    {        
        [JsonPropertyName("id")]
        public string ClientId { get; set; } = null!;

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("quantity")]
        public int OrderQuantity { get; set; }

        [JsonPropertyName("vatId")]
        public int VATId { get; set; }

        [JsonPropertyName("parts")]
        public ICollection<OrderPartIdDto> OrderParts { get; set; } = new List<OrderPartIdDto>();
    }
}
