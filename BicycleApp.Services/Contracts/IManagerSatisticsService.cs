namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.ManagerStatistics;
    using BicycleApp.Services.Models.Order.OrderManager;

    public interface IManagerSatisticsService
    {
        Task<PastAndCurrentEmployeeWorkingMinutesDto> GetEmployeeOutputForThePastAndCurrentMonth(string employeeId);
        Task<OrderStatisticDto> GetOrderStatistics(FinishedOrdersDto datesPeriod);
        Task<PartStatisticDto> GetPartStatistics(FinishedOrdersDto datesPeriod);
        Task<StatisticsDto> GetStatistics(FinishedOrdersDto datesPeriod);
    }
}
