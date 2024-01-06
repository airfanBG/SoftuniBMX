namespace BicycleApp.Services.Models.WorkerManagement
{
    using BicycleApp.Services.Models.WorkerManagement.Contracts;

    public class TotalSalary : ITotalSalary
    {
        public decimal Bonus { get; set; }
        public string EmployeeId { get; set; } = null!;
    }
}
