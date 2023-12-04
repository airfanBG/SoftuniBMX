namespace BicycleApp.Services.Contracts.OrderContracts
{
    using BicycleApp.Services.Models.Order.OrderUser;

    public interface IQualityAssuranceService
    {
        Task<ICollection<OrderProgretionDto>> GetAllReadyOrder();
        Task<bool> OrderPassQualityAssurance(int orderId);
    }
}
