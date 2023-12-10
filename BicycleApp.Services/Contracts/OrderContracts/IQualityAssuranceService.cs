namespace BicycleApp.Services.Contracts.OrderContracts
{
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public interface IQualityAssuranceService
    {
        Task<ICollection<OrderProgretionDto>> GetAllReadyOrder();
        Task<bool> OrderPassQualityAssurance(int orderId);
        Task<ICollection<RemanufacturingPartEmployeeInfoDto>> RemanufacturingPart(IOrderProgretionDto orderProgretionDto);
    }
}
