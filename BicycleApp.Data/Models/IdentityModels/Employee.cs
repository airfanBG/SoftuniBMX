namespace BicycleApp.Data.Models.IdentityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Models.EntityModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.Constants.EntityValidationConstants.User;

    public class Employee : BaseUser
    {
        public Employee()
        {
            this.OrdersPartsEmployees = new HashSet<OrderPartEmployee>();
            this.ImagesEmployees = new HashSet<ImageEmployee>();
            this.EmployeeMonthSalaryInfos = new HashSet<EmployeeMonthSalaryInfo>();
        }


        [Required]
        [MaxLength(PositionMaxLength)]
        [Comment("Current position of the employee in the company")]
        public string Position { get; set; } = null!;

        [Required]
        [Comment("Date of hire of the employee")]
        public DateTime DateOfHire { get; set; }

        [Comment("Date of termination of the employee")]
        public DateTime? DateOfLeave { get; set; }

        [Required]
        [Comment("Id of the current department of the employee")]
        public int DepartmentId { get; set; }

        [Required]
        [Comment("Base salary of hired employee")]
        [Precision(7,2)]
        public decimal BaseSalary { get; set; }

        [Required]
        [Comment("Internship in months for salary calculation")]
        public int InternshipInMonths { get; set; }

        public virtual Department Department { get; set; } = null!;

        public virtual ICollection<OrderPartEmployee> OrdersPartsEmployees { get; set; }

        [Required]
        public bool IsManeger { get; set; } = false;

        public virtual ICollection<ImageEmployee> ImagesEmployees { get; set; }       
        public virtual ICollection<EmployeeMonthSalaryInfo> EmployeeMonthSalaryInfos { get; set; }       
    }
}
