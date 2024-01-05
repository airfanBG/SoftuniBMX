namespace BicycleApp.Services.Models.ManagerStatistics
{
    using BicycleApp.Services.Models.ManagerStatistics.Contracts;

    public class BaseSalary : IBaseSalary
    {
        public decimal? Bonus { get; set; }
        public string EmployeeId { get; set; } = null!;
    }
}
