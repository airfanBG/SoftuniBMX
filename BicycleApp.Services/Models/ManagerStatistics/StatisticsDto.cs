using BicycleApp.Services.Models.Order.OrderManager;


namespace BicycleApp.Services.Models.ManagerStatistics
{
    public class StatisticsDto
    {
        public OrderStatisticDto OrderStatistics { get; set; } = null!;
        public PartStatisticDto TotalPartStatistics { get; set; } = null!;
        public PartStatisticDto PeriodPartStatistics { get; set; } = null!;
    }
}
