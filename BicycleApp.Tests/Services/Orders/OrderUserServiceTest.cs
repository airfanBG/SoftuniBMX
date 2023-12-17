namespace BicycleApp.Tests.Services.Orders
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Common;
    using BicycleApp.Common.Providers;
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using BicycleApp.Services.Services.Factory;
    using BicycleApp.Services.Services.Orders;
    using FakeItEasy;

    [TestFixture]
    internal class OrderUserServiceTest
    {
        private static BicycleAppDbContext db = new BicycleAppDbContext();
        private static IStringManipulator stringManipulator = new StringManipulator();
        private static IDateTimeProvider dateTimeProvider = new DateTimeProvider();
        private static IOrderFactory orderFactory = new OrderFactory(db, dateTimeProvider);
        private static IGuidProvider guidProvider = new GuidProvider();

        private static Part part1 = new Part()
        {
            CategoryId = 1,
            SalePrice = 100,
            VATCategoryId = 1,
        };        

        private readonly IOrderUserService orderUserService = new OrderUserService(db, stringManipulator, orderFactory, guidProvider, dateTimeProvider);

        [Test]
        public async Task CreateOrderByUserAsync_Should_ReturnNull_WhenDiscountIsGreaterThanSalePrice()
        {
            // Arrange
            IUserOrderDto invalidOrder = new UserOrderDto()
            {
                VATId = 1,
                ClientId = "",
                OrderQuantity = 1,
                OrderParts = new List<OrderPartIdDto>()
                {
                    new OrderPartIdDto(){ PartId = 1 }
                }
            };

            // Act 
            var result = await orderUserService.CreateOrderByUserAsync(invalidOrder);

            // Assert
            Assert.IsNull(result);
        }
    }
}
