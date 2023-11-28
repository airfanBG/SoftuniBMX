namespace BicycleApp.Services.Contracts
{
    using System.Threading.Tasks;

    using BicycleApp.Services.Models.Order;

    public interface IEmployeeOrderService
    {
        Task<EmployeePartOrdersDto> GetAllOrdersAsignedToEmployee(string employeeId);

        Task<bool> StartOrderByEmployee(PartOrdersStartEndDto partOrdersStartEndDto);
        
        Task<bool> EndOrderByEmployee(PartOrdersStartEndDto partOrdersStartEndDto);
    }
}
