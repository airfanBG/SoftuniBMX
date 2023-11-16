namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Models.IdentityModels;

    public interface IModelsFactory
    {
        Client CreateNewClientModel(ClientRegisterDto clientRegisterDto);

        Employee CreateNewEmployee(EmployeeRegisterDto employeeRegisterDto);

        Town CreateNewTown(string townName);

        Department CreateNewDepartment(string departmentName);
    }
}
