namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Order;

    public class EmployeeFactory : IEmployeeFactory
    {
        public RemanufacturingPartEmployeeInfoDto CreateRemanufacturingOrderPart(string employeeName, string partName, string serialNumber, string? description)
        {
            return new RemanufacturingPartEmployeeInfoDto()
            {
                EmployeeName = employeeName,
                PartName = partName,
                SerialNumber = serialNumber,
                Description = description
            };
        }
    }
}
