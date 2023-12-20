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
    using Microsoft.EntityFrameworkCore;
    using Moq.EntityFrameworkCore;
    using Moq;

    [TestFixture]
    internal class OrderUserServiceTest
    {
        //To 
        private static BicycleAppDbContext fakeContext;
        private static IStringManipulator fakeStringManipulator;
        private static IDateTimeProvider fakeDateTimeProvider;
        private static IOrderFactory fakeOrderFactory;
        private static IGuidProvider fakeGuidProvider;

        private readonly IOrderUserService orderUserService = new OrderUserService(fakeContext, fakeStringManipulator, fakeOrderFactory, fakeGuidProvider, fakeDateTimeProvider);

        [Test]
        public async Task CreateOrderByUserAsync_Should_ReturnNull_WhenDiscountIsGreaterThanSalePrice()
        {
            // Arrange
            var employeeContextMock = new Mock<BicycleAppDbContext>();
            employeeContextMock.Setup(x => x.VATCategories)
                .ReturnsDbSet(new List<VATCategory>(){ new VATCategory()
            {
               Id=  1,
               VATPercent = 20M,
            }});

            //A.CallTo(() => fakeContext.Parts.ToList()).Returns(parts);

            IUserOrderDto invalidOrder = new UserOrderDto()
            {
                VATId = 1,
                ClientId = "fakeClient",
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
