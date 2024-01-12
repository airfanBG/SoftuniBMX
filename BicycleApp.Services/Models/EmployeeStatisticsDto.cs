using BicycleApp.Services.Models.Order.OrderManager;


namespace BicycleApp.Services.Models
{    
    public class EmployeeStatisticsDto
    {
        public StatisticEmployeeDto EmployeeFullStatistics { get; set; } = null!;
        public StatisticEmployeeDto EmployeePeriodStatistics { get; set; } = null!;
    }
}
