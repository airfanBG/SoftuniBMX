namespace BicycleApp.Services.Models.Order
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    public class EmployeePartOrdersDto
    {
        [Required]
        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; } = null!;

        [JsonProperty("orders")]
        public ICollection<PartOrdersDto> Orders { get; set; } = new List<PartOrdersDto>();
    }
}
