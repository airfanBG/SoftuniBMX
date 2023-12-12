using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BicycleApp.Services.Models.Order.OrderManager
{
    public class FinishedOrdersDto
    {
        [Required]
        [JsonPropertyName("start_date")]
        public DateTime StartDate { get; set; } 

        [Required]
        [JsonPropertyName("end_date")]
        public DateTime EndDate { get; set; } 
    }
}
