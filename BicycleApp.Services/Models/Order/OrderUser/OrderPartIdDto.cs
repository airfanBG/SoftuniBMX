namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using System.Text.Json.Serialization;
        
    public class OrderPartIdDto : IOrderPartIdDto
    {
        [JsonPropertyName("partId")]
        public int PartId { get; set; }
    }
}