namespace BicycleApp.Services.Models.ManagerStatistics
{
    using BicycleApp.Services.Models.ManagerStatistics.Contracts;

    public class SalaryOverview : ISalaryOverview
    {
        public string EmployeeId { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string CurrentMonth { get; set; } = null!;
        public string TotalSalary { get; set; } = null!;
    }
}
