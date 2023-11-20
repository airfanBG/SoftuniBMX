namespace BicycleApp.Services.Contracts.Factory
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Models.Order;

    public interface IOrderFactory
    {
        public Order CreateUserOrder();
    }
}
