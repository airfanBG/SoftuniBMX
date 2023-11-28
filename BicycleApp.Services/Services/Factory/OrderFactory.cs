namespace BicycleApp.Services.Services.Factory
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;

    public class OrderFactory : IOrderFactory
    {       
        public Order CreateUserOrder()
        {
            return new Order();
        }
    }
}
