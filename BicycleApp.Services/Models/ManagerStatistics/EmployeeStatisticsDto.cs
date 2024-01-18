using BicycleApp.Services.Models.Order.OrderManager;


namespace BicycleApp.Services.Models.ManagerStatistics
{
    public class EmployeeStatisticsDto
    {
        public StatisticEmployeeDto EmployeeFullStatistics { get; set; } = null!;
        public StatisticEmployeeDto EmployeePeriodStatistics { get; set; } = null!;
    }
}
