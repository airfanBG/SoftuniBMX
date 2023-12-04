namespace BicycleApp.Services.Contracts.Factory
{
    using BicycleApp.Services.Models.Order;

    public interface IEmployeeFactory
    {
        RemanufacturingPartEmployeeInfoDto CreateRemanufacturingOrderPart(string EmployeeName, string PartName, string SerialNumber, string? Description);
    }
}
