namespace BicycleApp.Services.Models
{
    using BicycleApp.Services.Models.Order.OrderUser;
    using System.Text.Json.Serialization;

    public class BikeStandartTypeDto
    {
        public int Id { get; set; }

        public string? ModelName { get; set; }

        public string? ImageUrl { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        [JsonPropertyName("parts")]
        public ICollection<OrderPartIdDto> OrderParts { get; set; } = new List<OrderPartIdDto>();
    }
}
