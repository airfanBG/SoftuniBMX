namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.WorkerManagement.Contracts;
    using BicycleApp.Services.Models.WorkerManagement;

    public interface IWorkerManagement
    {
        Task<SalaryOverview> EmployeeSalaryCalculation(ITotalSalary baseSalary);
    }
}
