namespace BicycleApp.Services.Models.WorkerManagement
{
    using BicycleApp.Services.Models.WorkerManagement.Contracts;

    public class SalaryOverview : ISalaryOverview
    {
        public string EmployeeId { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string CurrentMonth { get; set; } = null!;
        public string TotalSalary { get; set; } = null!;
    }
}
