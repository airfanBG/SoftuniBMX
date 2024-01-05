namespace BicycleApp.Services.Models.ManagerStatistics.Contracts
{    
    public interface IBaseSalary
    {
        public decimal? Bonus { get; set; }
        public string EmployeeId { get; set; }
    }
}
