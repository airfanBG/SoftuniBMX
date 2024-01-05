namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Common.Models;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Order;
    using System;

    public class EmployeeFactory : IEmployeeFactory
    {
        public OrderPartEmployeeInfo CreateOrderPartEmployeeInfo(TimeSpan partProductionTime, int orderId, string uniqueKeyForSerialNumber, int partId)
        {
            return new OrderPartEmployeeInfo()
            {
                OrderId = orderId,
                PartId = partId,
                UniqueKeyForSerialNumber = uniqueKeyForSerialNumber,
                ProductionТime = partProductionTime
            };
        }

        public RemanufacturingPartEmployeeInfoDto CreateRemanufacturingOrderPart(string employeeName, string partName, string serialNumber, string? description)
        {
            return new RemanufacturingPartEmployeeInfoDto()
            {
                EmployeeName = employeeName,
                PartName = partName,
                SerialNumber = serialNumber,
                Description = description
            };
        }

        public EmployeeMonthSalaryInfo CreateEmployeeMonthSalaryInfo(decimal baseSalary, decimal internshipValue, decimal monthBonus, SalaryAccrualPercentages salaryAccrualPercentages, string employeeId, DateTime currentDate)
        {
            decimal totalSalary = baseSalary + internshipValue + monthBonus;

            decimal dooValue = Math.Round((totalSalary * (salaryAccrualPercentages.DOO / 100)), 2); 
            decimal dzpoValue = Math.Round((totalSalary * (salaryAccrualPercentages.DZPO / 100)), 2); 
            decimal zoValue = Math.Round((totalSalary * (salaryAccrualPercentages.ZO / 100)), 2);

            decimal totalInsurance = dooValue + dzpoValue + zoValue;

            decimal taxableAmount = totalSalary - totalInsurance;

            decimal ddflValue = Math.Round((taxableAmount * (salaryAccrualPercentages.DDFL / 100)), 2);

            decimal netSalaryValue = totalSalary - totalInsurance - ddflValue;

            return new EmployeeMonthSalaryInfo()
            {
                EmployeeId = employeeId,
                BaseSalary = baseSalary,
                InternshipValue = internshipValue,
                MonthBonus = monthBonus,
                DOO = dooValue,
                DZPO = dzpoValue,
                ZO = zoValue,
                DDFL = ddflValue,
                NetSalary = netSalaryValue,
                Month = currentDate
            };
        }
    }
}
