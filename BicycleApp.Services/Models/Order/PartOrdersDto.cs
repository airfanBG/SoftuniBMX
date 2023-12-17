namespace BicycleApp.Services.Models.Order
{
    using Newtonsoft.Json;

    public class PartOrdersDto
    {
        [JsonProperty("orderNumber")]
        public string OrderSerialNumber { get; set; } = null!;

        [JsonProperty("partId")]
        public int PartId { get; set; }
        [JsonProperty("orderId")]
        public int OrderId { get; set; }

        [JsonProperty("partName")]
        public string PartName { get; set; } = null!;

        [JsonProperty("oem")]
        public string? PartOEMNumber { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("start")]
        public string DatetimeAsigned { get; set; } = null!;

        public string? DatetimeStarted { get; set; }

        [JsonProperty("finish")]
        public string? DatetimeFinished { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
