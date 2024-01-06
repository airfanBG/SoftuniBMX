namespace BicycleApp.Services.Models.WorkerManagement.Contracts
{
    public interface ITotalSalary
    {
        public decimal Bonus { get; set; }
        public string EmployeeId { get; set; }
    }
}
