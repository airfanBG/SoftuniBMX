namespace BicycleApp.Data.Models.EntityModels
{
    using BicycleApp.Data.Models.IdentityModels;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class EmployeeMonthSalaryInfo
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Employee))]
        public string EmployeeId { get; set; } = null!;
        public Employee Employee { get; set; } = null!;
        public DateTime Month { get; set; }

        [Precision(7,2)]
        public decimal BaseSalary { get; set; }

        [Precision(7, 2)]
        public decimal InternshipValue { get; set; }

        [Precision(7, 2)]
        public decimal MonthBonus { get; set; }

        [Precision(7, 2)]
        public decimal DOO { get; set; }

        [Precision(7, 2)]
        public decimal DZPO { get; set; }

        [Precision(7, 2)]
        public decimal ZO { get; set; }

        [Precision(7, 2)]
        public decimal DDFL { get; set; }

        [Precision(7, 2)]
        public decimal NetSalary { get; set; }
    }
}
