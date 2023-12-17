namespace BicycleApp.Services.Models.Order
{
    using Newtonsoft.Json;

    public class PartOrdersStartEndDto
    {
        [JsonProperty("partId")]
        public int PartId { get; set; }

        [JsonProperty("orderId")]
        public int OrderId { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; } = null!;

        [JsonProperty("datetime")]
        public string DateTime { get; set; } = null!;

    }
}
