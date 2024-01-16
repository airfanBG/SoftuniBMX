namespace BicycleApp.Tests.Services.Orders
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using BicycleApp.Services.Services.Orders;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Moq.EntityFrameworkCore;

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
        public void CreateOrderByUser_ShouldReturnNull_WhenDiscountIsGreaterThanSalePrice()
        {
            Part invalidPart = new Part()
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
            fakeContext.Setup(x => x.Parts).ReturnsDbSet(new List<Part> { invalidPart});
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
            fakeContext.Reset();
        }

        [Test]
        public void CreateOrderByUser_ShouldReturNull_WhenUserDontHaveEnoughBalance()
        {
            // Arrange
            Part part = new Part()
            {
                Id = 2,
                Name = "Frame Road",
                Description = "Best frame in the road!",
                Intend = "For road usage",
                OEMNumber = "oemtest1",
                Type = 1,
                CategoryId = 1,
                Quantity = 32,
                SalePrice = 100.00M,
                Discount = 0M,
                VATCategoryId = 1,
                DateCreated = new DateTime(2024, 1, 1),
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

            Client client = new Client
            {
                Id = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Email = "client@test.bg",
                UserName = "client@test.bg",
                NormalizedEmail = "client@test.bg".ToUpper(),
                SecurityStamp = "client@test.bg".ToUpper(),
                FirstName = "Ivan",
                LastName = "Ivanov",
                PhoneNumber = "1234567890",
                DelivaryAddressId = 1,
                TownId = 1,
                IBAN = "BG0012345678910111212",
                Balance = 19.00M,
                IsDeleted = false,
                DateCreated = new DateTime(2024, 1, 1),
                EmailConfirmed = true
            };

            fakeContext.Setup(x => x.Clients).ReturnsDbSet(new List<Client> { client });

            IUserOrderDto order = new UserOrderDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                OrderQuantity = 1,
                VATId = 1,
                OrderParts = new List<OrderPartIdDto>() { new OrderPartIdDto() { PartId = 2 } }
            };
            OrderPartDto op = new OrderPartDto
            {
                PartId = 2,
                PartName = "Frame Road",
                PartPrice = 100.00M,
                PartQuantity = 1
            };
            fakeOrdeFaktory.Setup(x => x.CreateOrderPartFromUserOrder(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<decimal>())).Returns(op);            

            // Act 
            var result = fakeOrderUserService.CreateOrderByUser(order);

            // Assert
            Assert.IsNull(result);
        }
        [Test]
        public void CreateOrderByUser_ShouldConfirmDatabaseSave()
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
                Discount = 0M,
                VATCategoryId = 1,
                DateCreated = new DateTime(2024, 1, 1),
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

            Client client = new Client
            {
                Id = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Email = "client@test.bg",
                UserName = "client@test.bg",
                NormalizedEmail = "client@test.bg".ToUpper(),
                SecurityStamp = "client@test.bg".ToUpper(),
                FirstName = "Ivan",
                LastName = "Ivanov",
                PhoneNumber = "1234567890",
                DelivaryAddressId = 1,
                TownId = 1,
                IBAN = "BG0012345678910111212",
                Balance = 1900.00M,
                IsDeleted = false,
                DateCreated = new DateTime(2024, 1, 1),
                EmailConfirmed = true
            };

            fakeContext.Setup(x => x.Clients).ReturnsDbSet(new List<Client> { client });

            IUserOrderDto order = new UserOrderDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                OrderQuantity = 1,
                VATId = 1,
                OrderParts = new List<OrderPartIdDto>() { new OrderPartIdDto() { PartId = 1 } }
            };
            OrderPartDto op = new OrderPartDto
            {
                PartId = 1,
                PartName = "Frame Road",
                PartPrice = 100.00M,
                PartQuantity = 1
            };
            fakeOrdeFaktory.Setup(x => x.CreateOrderPartFromUserOrder(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<decimal>())).Returns(op);
            Order newOrder = new Order()
            {
                FinalAmount = 100.00M,
                PaidAmount = 0.00M,
                SaleAmount = 83.33M,
                UnpaidAmount = 0.00M,
                VAT = 16.66M,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                DateCreated = new DateTime(2024, 1, 1),
            };

            fakeOrdeFaktory.Setup(x => x.CreateUserOrder(It.IsAny<IOrder>(), It.IsAny<DateTime>())).Returns(newOrder);
            var fakeOrderDbSet = new Mock<DbSet<Order>>();
            fakeContext.Setup(x => x.Orders).Returns(fakeOrderDbSet.Object);
            int actualAddedOrderInDb = 0;
            int actualSavedOrderInDb = 0;

            fakeOrderDbSet.Setup(x => x.Add(It.IsAny<Order>())).Callback(() => actualAddedOrderInDb++);
            fakeContext.Setup(x => x.SaveChanges()).Callback(() => actualSavedOrderInDb++);
            // Act 
            var result = fakeOrderUserService.CreateOrderByUser(order);
            int expectedAddedOrderInDb = 1;
            int expectedSavedOrderInDb = 1;

            // Assert
            Assert.AreEqual(expectedAddedOrderInDb, actualAddedOrderInDb);
            Assert.AreEqual(expectedSavedOrderInDb, actualSavedOrderInDb);
        }
        [Test]
        public void CreateOrderByUser_ShouldReturnCorrectDataForNewOrder()
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
                Discount = 0M,
                VATCategoryId = 1,
                DateCreated = new DateTime(2024, 1, 1),
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

            Client client = new Client
            {
                Id = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Email = "client@test.bg",
                UserName = "client@test.bg",
                NormalizedEmail = "client@test.bg".ToUpper(),
                SecurityStamp = "client@test.bg".ToUpper(),
                FirstName = "Ivan",
                LastName = "Ivanov",
                PhoneNumber = "1234567890",
                DelivaryAddressId = 1,
                TownId = 1,
                IBAN = "BG0012345678910111212",
                Balance = 1900.00M,
                IsDeleted = false,
                DateCreated = new DateTime(2024, 1, 1),
                EmailConfirmed = true
            };

            fakeContext.Setup(x => x.Clients).ReturnsDbSet(new List<Client> { client });

            IUserOrderDto order = new UserOrderDto()
            {
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                OrderQuantity = 1,
                VATId = 1,
                OrderParts = new List<OrderPartIdDto>() { new OrderPartIdDto() { PartId = 1 } }
            };
            OrderPartDto op = new OrderPartDto
            {
                PartId = 1,
                PartName = "Frame Road",
                PartPrice = 100.00M,
                PartQuantity = 1
            };
            fakeOrdeFaktory.Setup(x => x.CreateOrderPartFromUserOrder(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>(), It.IsAny<decimal>())).Returns(op);
            Order newOrder = new Order()
            {
                FinalAmount = 100.00M,
                PaidAmount = 0.00M,
                SaleAmount = 83.33M,
                UnpaidAmount = 0.00M,
                VAT = 16.67M,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                DateCreated = new DateTime(2024, 1, 1),
            };

            fakeOrdeFaktory.Setup(x => x.CreateUserOrder(It.IsAny<IOrder>(), It.IsAny<DateTime>())).Returns(newOrder);
            var fakeOrderDbSet = new Mock<DbSet<Order>>();
            fakeContext.Setup(x => x.Orders).Returns(fakeOrderDbSet.Object);
            // Act 
            var result = fakeOrderUserService.CreateOrderByUser(order);

            // Assert
            Assert.AreEqual(newOrder.ClientId, result.ClientId);
            Assert.AreEqual(newOrder.FinalAmount, result.FinalAmount);
            Assert.AreEqual(newOrder.VAT, result.VAT);
            Assert.AreEqual(newOrder.SaleAmount, result.SaleAmount);
        }


    }
}
