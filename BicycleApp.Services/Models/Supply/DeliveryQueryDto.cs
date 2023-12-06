using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace BicycleApp.Services.Models.Supply
{
    public class DeliveryQueryDto 
    {
        public int TotalDeliveriesCount { get; set; }
        public IEnumerable<DeliveryDetailsDto> Deliveries { get; set; } = new List<DeliveryDetailsDto>();
    }
}
