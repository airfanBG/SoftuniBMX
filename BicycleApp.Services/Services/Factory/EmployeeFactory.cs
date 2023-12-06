namespace BicycleApp.Services.Services.Factory
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Order;
    using System;

    public class EmployeeFactory : IEmployeeFactory
    {
        public async Task<OrderPartEmployeeInfo> CreateOrderPartEmployeeInfo(TimeSpan partProductionTime, int orderId, string uniqueKeyForSerialNumber, int partId)
        {
            return new OrderPartEmployeeInfo()
            {
                OrderId = orderId,
                PartId = partId,
                UniqueKeyForSerialNumber = uniqueKeyForSerialNumber,
                ProductionТime = partProductionTime
            };
        }

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
