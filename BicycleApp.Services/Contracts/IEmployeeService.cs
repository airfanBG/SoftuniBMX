namespace BicycleApp.Services.Contracts
{
    using System.Threading.Tasks;

    using BicycleApp.Services.Models.IdentityModels;

    public interface IEmployeeService
    {
        Task<bool> RegisterEmployeeAsync(EmployeeRegisterDto employeeRegisterDto);

        Task<EmployeeReturnDto> LoginEmployeeAsync(EmployeeLoginDto employeeDto);

        Task<EmployeeInfoDto?> GetEmployeeInfoAsync(string Id);

        Task<bool> ChangeEmployeePasswordAsync(EmployeePasswordChangeDto employeePasswordChangeDto);
    }
}
