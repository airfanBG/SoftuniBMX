namespace BicycleApp.Services.Models.ManagerStatistics.Contracts
{   
    public interface ISalaryOverview
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string CurrentMonth { get; set; }
        public string TotalSalary { get; set; }
    }
}
