namespace BicycleApp.Services.Models.IdentityModels.Contracts
{    
    public interface IEmployeeSalaryInfo
    {
        public EmployeeSalaryDateDto Month { get; set; }
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
