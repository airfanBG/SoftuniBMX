﻿namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using System.Text.Json.Serialization;

    public class OrderProgretionDto : IOrderProgretionDto
    {
        [JsonPropertyName("orderId")]
        public int OrderId { get; set; }
        public string? SerialNumber { get; set; }
        public string DateCreated { get; set; } = null!;
        public string? DateFinished { get; set; } = null!;
        public ICollection<OrderStateDto> OrderStates { get; set; } = new List<OrderStateDto>();
    }
}
