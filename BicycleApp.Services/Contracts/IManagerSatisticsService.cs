namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.ManagerStatistics;

    public interface IManagerSatisticsService
    {
        Task<PastAndCurrentEmployeeWorkingMinutesDto> GetEmployeeOutputForThePastAndCurrentMonth(string employeeId);
    }
}
