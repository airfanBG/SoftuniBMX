namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.ManagerStatistics;
    using BicycleApp.Services.Models.ManagerStatistics.Contracts;

    public interface IManagerSatisticsService
    {
        Task<PastAndCurrentEmployeeWorkingMinutesDto> GetEmployeeOutputForThePastAndCurrentMonth(string employeeId);
        Task<SalaryOverview> EmployeeSalaryCalculation(IBaseSalary baseSalary);
    }
}
