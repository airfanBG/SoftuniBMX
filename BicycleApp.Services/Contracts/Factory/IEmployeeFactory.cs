namespace BicycleApp.Services.Contracts.Factory
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Models.Order;

    public interface IEmployeeFactory
    {
        RemanufacturingPartEmployeeInfoDto CreateRemanufacturingOrderPart(string EmployeeName, string PartName, string SerialNumber, string? Description);
        Task<OrderPartEmployeeInfo> CreateOrderPartEmployeeInfo(TimeSpan partProductionTime, int orderId, string uniqueKeyForSerialNumber, int partId);
    }
}
