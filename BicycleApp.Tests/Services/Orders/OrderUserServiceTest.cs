namespace BicycleApp.Tests.Services.Orders
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using BicycleApp.Services.Services.Orders;
    using Moq;
    using Moq.EntityFrameworkCore;
    using NUnit.Framework.Constraints;

    [TestFixture]
    internal class OrderUserServiceTest
    {
        private static readonly Mock<BicycleAppDbContext> fakeContext = new Mock<BicycleAppDbContext>();
        private static readonly Mock<IStringManipulator> fakeStringManipulator = new Mock<IStringManipulator>();
        private static readonly Mock<IOrderFactory> fakeOrdeFaktory = new Mock<IOrderFactory>();
        private static readonly Mock<IDateTimeProvider> fakeDateTimeProvider = new Mock<IDateTimeProvider>();

        private readonly IOrderUserService fakeOrderUserService;

        public OrderUserServiceTest()
        {
            fakeOrderUserService = new OrderUserService(fakeContext.Object, fakeStringManipulator.Object, fakeOrdeFaktory.Object, fakeDateTimeProvider.Object);
        }

        [Test]
        public async Task CreateOrderByUserAsync_Should_ReturnNull_WhenDiscountIsGreaterThanSalePrice()
        {
            // Arrange
            Part part = new Part()
            {
                Id = 1,
                Name = "Frame Road",
                Description = "Best frame in the road!",
                Intend = "For road usage",
                OEMNumber = "oemtest1",
                Type = 1,
                CategoryId = 1,
                Quantity = 32,
                SalePrice = 100.00M,
                Discount = 120.00M,
                VATCategoryId = 1,
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false
            };
            fakeContext.Setup(x => x.Parts).ReturnsDbSet(new List<Part> { part });
            VATCategory vatCategory = new VATCategory()
            {
                Id = 1,
                VATPercent = 20.00M,
                DateCreated = new DateTime(2024, 1, 1),
            };
            fakeContext.Setup(x => x.VATCategories).ReturnsDbSet(new List<VATCategory> { vatCategory });
            

            IUserOrderDto order = new UserOrderDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Description = "someDescription",
                OrderQuantity = 1,
                VATId = 1,
                OrderParts = new List<OrderPartIdDto>() { new OrderPartIdDto() { PartId = 1 } }
            };

            // Act 
            var result = fakeOrderUserService.CreateOrderByUser(order);

            // Assert
            Assert.IsNull(result);
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
            var result = fakeOrderUserService.CreateOrderByUser(order);

            // Assert
            Assert.IsNull(result);
        }
        [Test]
        public async Task CreateOrderByUserAsync_Should_ReturNull_WhenClientDoNotHaveEnoughBalance()
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
            var result = fakeOrderUserService.CreateOrderByUser(order);

            // Assert
            Assert.IsNull(result);
        }

    }
}
