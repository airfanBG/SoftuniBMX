namespace BicycleApp.Tests.Services.Orders
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.SeedData;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using BicycleApp.Services.Services.Orders;
    using Moq;
    using Moq.EntityFrameworkCore;

    [TestFixture]
    internal class OrderUserServiceTest
    {
        private static readonly Mock<BicycleAppDbContext> fakeContext = new Mock<BicycleAppDbContext>();
        private static readonly Mock<IStringManipulator> fakeStringManipulator = new Mock<IStringManipulator>();
        private static readonly Mock<IOrderFactory> fakeOrdeFaktory = new Mock<IOrderFactory>();
        private static readonly Mock<IDateTimeProvider> fakeDateTimeProvider = new Mock<IDateTimeProvider>();

        private readonly IOrderUserService fakeOrderUserService = new OrderUserService(fakeContext.Object, fakeStringManipulator.Object, fakeOrdeFaktory.Object, fakeDateTimeProvider.Object);

        [OneTimeSetUp]
        public void SetUp()
        {
            var seeder = new SeedClass();

            fakeDateTimeProvider.Setup(x => x.Now).Returns(new DateTime(2023, 11, 11, 11, 11, 00));

            fakeContext.Setup(x => x.VATCategories)
               .ReturnsDbSet(seeder.SeedVATCategories());
            fakeContext.Setup(x => x.Parts)
                .ReturnsDbSet(seeder.SeedParts());
            fakeContext.Setup(x => x.Clients)
                .ReturnsDbSet(seeder.SeedClients());
            fakeContext.Setup(x => x.Orders)
                .ReturnsDbSet(seeder.SeedOrders());
        }

        [Test]
        public async Task CreateOrderByUserAsync_Should_ReturnNull_WhenDiscountIsGreaterThanSalePrice()
        {
            // Arrange
            IUserOrderDto order = new UserOrderDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "someDescription",
                OrderQuantity = 1,
                VATId = 1,
                OrderParts = new List<OrderPartIdDto>() { new OrderPartIdDto() { PartId = 18 } }
            };

            // Act 
            var result = await fakeOrderUserService.CreateOrderByUserAsync(order);

            // Assert
            Assert.IsNull(result);
        }
        [Test]
        public async Task CreateOrderByUserAsync_Should_ReturNewOrderObject_WhenUserSuccesfulyMadeOrder()
        {
            // Arrange
            IUserOrderDto order = new UserOrderDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "someDescription",
                OrderQuantity = 1,
                VATId = 1,
                OrderParts = new List<OrderPartIdDto>() { new OrderPartIdDto() { PartId = 2 } }
            };

            var fakeDate = fakeDateTimeProvider.Object.Now;

            fakeOrdeFaktory.Setup(x => x.CreateUserOrder(It.IsAny<IOrder>(), fakeDate))
                .Returns(new Order() 
                            {
                                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                                StatusId = 2, 
                                SaleAmount = 456,
                                Description = "descroption",
                                FinalAmount = 546,
                                VAT = 123
                            });

            // Act 
            var result = await fakeOrderUserService.CreateOrderByUserAsync(order);

            // Assert
            Assert.IsNotNull(result);
        }
        [Test]
        public async Task CreateOrderByUserAsync_Should_ReturNull_WhenUserDontHaveEnoughBalance()
        {
            // Arrange
            IUserOrderDto order = new UserOrderDto()
            {
                ClientId = "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                Description = "someDescription",
                OrderQuantity = 1,
                VATId = 1,
                OrderParts = new List<OrderPartIdDto>() { new OrderPartIdDto() { PartId = 2 } }
            };           

            // Act 
            var result = await fakeOrderUserService.CreateOrderByUserAsync(order);

            // Assert
            Assert.IsNull(result);
        }
        [Test]
        public async Task CreateOrderByUserAsync_Should_ReturTrue_WhenOrderIsCorrectlyCalculatedWithoutDiscount()
        {
            // Arrange
            IUserOrderDto order = new UserOrderDto()
            {
                ClientId = "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                Description = "someDescription",
                OrderQuantity = 1,
                VATId = 1,
                OrderParts = new List<OrderPartIdDto>() { new OrderPartIdDto() { PartId = 2 }, new OrderPartIdDto() { PartId = 4 }, new OrderPartIdDto() { PartId = 7 } }
            };

            decimal sumOfParts = 0;
            foreach (var orderedPart in order.OrderParts)
            {
                sumOfParts += fakeContext.Object.Parts.FirstOrDefault(p => p.Id == orderedPart.PartId).SalePrice;
            }

            // Act 
            var result = await fakeOrderUserService.CreateOrderByUserAsync(order);

            // Assert
            Assert.AreEqual(sumOfParts, result.FinalAmount);
        }
    }
}
