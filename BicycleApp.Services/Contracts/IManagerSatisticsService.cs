namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.ManagerStatistics;
    using BicycleApp.Services.Models.Order.OrderManager;

    public interface IManagerSatisticsService
    {
        Task<PastAndCurrentEmployeeWorkingMinutesDto> GetEmployeeOutputForThePastAndCurrentMonth(string employeeId);
        Task<OrderStatisticDto> GetOrderStatistics(FinishedOrdersDto datesPeriod);
        Task<PartStatisticDto> GetTotalPartStatistics();
        Task<PartStatisticDto> GetPeriodPartStatistics(FinishedOrdersDto datesPeriod);
        Task<StatisticsDto> GetStatistics(FinishedOrdersDto datesPeriod);
        Task<StatisticEmployeeDto> EmployeeFullStatistics(string httpScheme, string httpHost, string httpPathBase);
        Task<StatisticEmployeeDto> EmployeePeriodStatistics(FinishedOrdersDto datesPeriod, string httpScheme, string httpHost, string httpPathBase);
        Task<EmployeeStatisticsDto> GetEmployeesStatistics(FinishedOrdersDto datesPeriod, string httpScheme, string httpHost, string httpPathBase);
    }
}
