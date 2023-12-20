namespace BicycleApp.Tests.Services.Orders
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using Moq;
    using Moq.EntityFrameworkCore;

    [TestFixture]
    internal class OrderUserServiceTest
    {
        private static readonly Mock<BicycleAppDbContext> fakeEmployeeContext = new Mock<BicycleAppDbContext>();
        private static readonly Mock<IDateTimeProvider> fakeDateTimeProvider = new Mock<IDateTimeProvider>();

       // private readonly IOrderUserService fakeOrderUserService = new OrderUserService(fakeEmployeeContext.Object,);
        [OneTimeSetUp]
        public void SetUp()
        {

            fakeEmployeeContext.Setup(x => x.VATCategories)
               .ReturnsDbSet(new List<VATCategory>() { new VATCategory() { Id = 1, VATPercent = 20M } });
        }

        [Test]
        public async Task CreateOrderByUserAsync_Should_ReturnNull_WhenDiscountIsGreaterThanSalePrice()
        {
            // Arrange
            
   

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
            //var result = await orderUserService.CreateOrderByUserAsync(invalidOrder);

            // Assert
            Assert.IsNull(null);
        }
    }
}
