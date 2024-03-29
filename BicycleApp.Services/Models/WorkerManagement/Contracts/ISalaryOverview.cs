﻿namespace BicycleApp.Services.Models.WorkerManagement.Contracts
{
    public interface ISalaryOverview
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string CurrentMonth { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
