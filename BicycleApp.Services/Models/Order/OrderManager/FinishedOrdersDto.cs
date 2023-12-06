using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BicycleApp.Services.Models.Order.OrderManager
{
    public class FinishedOrdersDto
    {
        [Required]
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; } 

        [Required]
        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; } 
    }
}
