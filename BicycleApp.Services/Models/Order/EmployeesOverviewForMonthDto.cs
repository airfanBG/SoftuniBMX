namespace BicycleApp.Services.Models.Order
{
    using BicycleApp.Services.Models.IdentityModels;

    public class EmployeesOverviewForMonthDto
    {
        public string RoleName { get; set; } = null!;
        public ICollection<EmployeeInfoDto> EmployeeInfos { get; set; } = new List<EmployeeInfoDto>();
        
    }
}
