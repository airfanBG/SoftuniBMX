namespace BicycleApp.Services.Models.IdentityModels
{
    using BicycleApp.Services.Models.IdentityModels.Contracts;

    public class EmployeeSalaryInfoDto : IEmployeeSalaryInfo
    {
        public string Month { get; set; } = null!;
        public decimal BaseSalary { get; set; }
        public decimal InternshipValue { get; set; }
        public decimal MonthBonus { get; set; }
        public decimal DOO { get; set; }
        public decimal DZPO { get; set; }
        public decimal ZO { get; set; }
        public decimal DDFL { get; set; }
        public decimal NetSalary { get; set; }
    }
}
