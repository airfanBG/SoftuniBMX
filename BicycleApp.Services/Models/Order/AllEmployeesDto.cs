namespace BicycleApp.Services.Models.Order
{    
    public class AllEmployeesDto
    {
        public ICollection<EmployeeRoleDto> Roles { get; set; } = new List<EmployeeRoleDto>();
    }
}
