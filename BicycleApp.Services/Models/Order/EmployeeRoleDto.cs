namespace BicycleApp.Services.Models.Order
{
    using BicycleApp.Services.Models.IdentityModels;

    public class EmployeeRoleDto
    {
        public ICollection<EmployeeInfoDto> EmployeesInfos { get; set; } = new List<EmployeeInfoDto>();
    }
}
