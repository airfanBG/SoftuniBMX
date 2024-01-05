using BicycleApp.Services.Models.Order.OrderManager;


namespace BicycleApp.Services.Models
{    
    public class StatisticsDto
    {
        public OrderStatisticDto OrderStatistics { get; set; } = null!;
        public PartStatisticDto PartStatistics { get; set; } = null!;
    }
}
