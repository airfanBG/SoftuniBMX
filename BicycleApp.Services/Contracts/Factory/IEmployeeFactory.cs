namespace BicycleApp.Services.Contracts.Factory
{
    using BicycleApp.Common.Models;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Models.Order;

    public interface IEmployeeFactory
    {
        RemanufacturingPartEmployeeInfoDto CreateRemanufacturingOrderPart(string EmployeeName, string PartName, string SerialNumber, string? Description);
        OrderPartEmployeeInfo CreateOrderPartEmployeeInfo(TimeSpan partProductionTime, int orderId, string uniqueKeyForSerialNumber, int partId);
        EmployeeMonthSalaryInfo CreateEmployeeMonthSalaryInfo(decimal baseSalary, decimal internshipValue, decimal monthBonus, SalaryAccrualPercentages salaryAccrualPercentages, string employeeId, DateTime currentDate);
    }
}
