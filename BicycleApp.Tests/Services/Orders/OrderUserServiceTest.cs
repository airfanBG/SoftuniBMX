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
    using NUnit.Framework.Internal;

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
        [Test]
        public async Task GetOrdersProgresions_ShouldReturnExactOneOrder()
        {
            //Arrange
            string clientId = "searchedClientId";

            Order orderWithCorrectClientId = new Order
            {
                Id = 1,
                ClientId = clientId,
                IsDeleted = false,
                DateFinish = null,
                DateCreated = new DateTime(2024,1,1),
                OrdersPartsEmployees = new List<OrderPartEmployee>
                                       {
                                            new OrderPartEmployee
                                            {                                                
                                                IsCompleted = true,
                                                EmployeeId = "test",
                                                Employee = new Employee
                                                {
                                                    FirstName = "Marin",
                                                    LastName = "Marinov",
                                                    Id = "test"
                                                },
                                                PartId = 1,
                                                Part = new Part
                                                {
                                                    Id = 1,
                                                    Name = "First part",
                                                    CategoryId = 1,
                                                    Category = new PartCategory
                                                    {
                                                        Id = 1,
                                                        Name = "Test category"
                                                    }
                                                },
                                                UniqueKeyForSerialNumber = "test serial number",
                                                DateCreated = new DateTime(2024, 1, 2, 13,1,1),
                                                DateFinish =  new DateTime(2024, 1, 2, 13,2,1)

                                            }
                                       }
            };
            Order orderWithIncorrectClientId = new Order
            {
                Id = 1,
                ClientId = "other client id",
                IsDeleted = false,
                DateFinish = null,
                DateCreated = new DateTime(2024, 1, 1),
                OrdersPartsEmployees = new List<OrderPartEmployee>
                                       {
                                            new OrderPartEmployee
                                            {
                                                IsCompleted = true,
                                                EmployeeId = "test",
                                                Employee = new Employee
                                                {
                                                    FirstName = "Marin",
                                                    LastName = "Marinov",
                                                    Id = "test"
                                                },
                                                PartId = 1,
                                                Part = new Part
                                                {
                                                    Id = 1,
                                                    Name = "First part",
                                                    CategoryId = 1,
                                                    Category = new PartCategory
                                                    {
                                                        Id = 1,
                                                        Name = "Test category"
                                                    }
                                                },
                                                UniqueKeyForSerialNumber = "test serial number",
                                                DateCreated = new DateTime(2024, 1, 2, 13,1,1),
                                                DateFinish =  new DateTime(2024, 1, 2, 13,2,1)

                                            }
                                       }
            };

            List<Order> orders = new List<Order>();
            orders.Add(orderWithCorrectClientId);
            orders.Add(orderWithIncorrectClientId);

            fakeContext.Setup(x => x.Orders).ReturnsDbSet(orders);

            //Act

            var actual = await fakeOrderUserService.GetOrdersProgresions(clientId);
            int actualClientOrders = actual.Count;
            int expectedClientOrders = 1;

            //Assert
            Assert.That(actualClientOrders, Is.EqualTo(expectedClientOrders));
        }
        [Test]
        public async Task GetOrdersProgresions_ShouldReturnCorrectPropertiesValue()
        {
            //Arrange
            string clientId = "searchedClientId";
            int orderId = 1;
            DateTime orderDateCreated = new DateTime(2024, 1, 1);
            string partModelName = "First part";
            string categoryName = "Test category";

            Order orderWithCorrectClientId = new Order
            {
                Id = orderId,
                ClientId = clientId,
                IsDeleted = false,
                DateFinish = null,
                DateCreated = orderDateCreated,
                OrdersPartsEmployees = new List<OrderPartEmployee>
                                       {
                                            new OrderPartEmployee
                                            {
                                                IsCompleted = true,
                                                EmployeeId = "test",
                                                Employee = new Employee
                                                {
                                                    FirstName = "Marin",
                                                    LastName = "Marinov",
                                                    Id = "test"
                                                },
                                                PartId = 1,
                                                Part = new Part
                                                {
                                                    Id = 1,
                                                    Name = partModelName,
                                                    CategoryId = 1,
                                                    Category = new PartCategory
                                                    {
                                                        Id = 1,
                                                        Name = categoryName
                                                    }
                                                },
                                                UniqueKeyForSerialNumber = "test serial number",
                                                DateCreated = new DateTime(2024, 1, 2, 13,1,1),
                                                DateFinish =  new DateTime(2024, 1, 2, 13,2,1)

                                            }
                                       }
            };

            List<Order> orders = new List<Order>();
            orders.Add(orderWithCorrectClientId);

            fakeContext.Setup(x => x.Orders).ReturnsDbSet(orders);

            //Act

            var actual = await fakeOrderUserService.GetOrdersProgresions(clientId);
            var actualOrderProgressionDto = actual.First();

            //Assert
            Assert.That(actualOrderProgressionDto.OrderId, Is.EqualTo(orderId));
            Assert.That(actualOrderProgressionDto.OrderStates.First().PartModel, Is.EqualTo(partModelName));
            Assert.That(actualOrderProgressionDto.OrderStates.First().PartType, Is.EqualTo(categoryName));
        }
        [Test]
        public void CreateOrderPartEmployeeByUserOrder_ShouldReturnTrue_WhenOrderPartEmployeeProductSuccessfulyIsAddedToDatabase()
        {
            //Arrange
            var input = new Mock<IOrderPartsEmplyee>();
            input.Setup(x => x.OrderQuantity).Returns(1);

            string testPartName = "test part name";
            decimal partPrice = 100.00M;
            int partQuantity = 1;
            int partId = 1;
            var orderPart = new Mock<IOrderPartDto>();
            orderPart.Setup(x => x.PartName).Returns(testPartName);
            orderPart.Setup(x => x.PartPrice).Returns(partPrice);
            orderPart.Setup(x => x.PartQuantity).Returns(partQuantity);
            orderPart.Setup(x => x.PartId).Returns(partId);

            input.Setup(x => x.OrderParts).Returns(new List<IOrderPartDto> { orderPart.Object });

            string serialNumber = "test serial number";
            fakeStringManipulator.Setup(x => x.SerialNumberGenerator()).Returns(serialNumber);

            string uniqueKeyForSerialNumber = "uniqueKeyForSerialNumber";
            fakeStringManipulator.Setup(x => x.CreateGuid()).Returns(uniqueKeyForSerialNumber);

            OrderPartEmployee returnOrderPartEmployee = new OrderPartEmployee
            {
                OrderId = 1,
                Order = new Order(),
                SerialNumber = serialNumber,
                UniqueKeyForSerialNumber = uniqueKeyForSerialNumber,
                DateCreated = new DateTime(2024, 1, 1),
                OrdersPartsEmployeesInfos = new List<OrderPartEmployeeInfo>(),
                Part = new Part()
                {
                    Id = partId,
                    Name = testPartName,
                    SalePrice = partPrice,
                    Quantity = partQuantity
                },
                PartId = partId,
                PartName = testPartName,
                PartPrice = partPrice,
                PartQuantity = partQuantity
            };

            fakeOrdeFaktory.Setup(x => x.CreateOrderPartEmployeeProduct(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<decimal>(), It.IsAny<DateTime>())).Returns(returnOrderPartEmployee);

            var fakeOrderPartEmployeeDbSet = new Mock<DbSet<OrderPartEmployee>>();
            fakeContext.Setup(x => x.OrdersPartsEmployees).Returns(fakeOrderPartEmployeeDbSet.Object);

            //Act
            var actual = fakeOrderUserService.CreateOrderPartEmployeeByUserOrder(input.Object);

            //Assert
            Assert.IsTrue(actual);
        }
        [Test]
        public void CreateOrderPartEmployeeByUserOrder_ShouldReturnCountOfInvokedMethods()
        {
            //Arrange
            var input = new Mock<IOrderPartsEmplyee>();
            input.Setup(x => x.OrderQuantity).Returns(1);

            string testPartName = "test part name";
            decimal partPrice = 100.00M;
            int partQuantity = 1;
            int partId = 1;
            var orderPart = new Mock<IOrderPartDto>();
            orderPart.Setup(x => x.PartName).Returns(testPartName);
            orderPart.Setup(x => x.PartPrice).Returns(partPrice);
            orderPart.Setup(x => x.PartQuantity).Returns(partQuantity);
            orderPart.Setup(x => x.PartId).Returns(partId);

            input.Setup(x => x.OrderParts).Returns(new List<IOrderPartDto> { orderPart.Object });

            string serialNumber = "test serial number";
            fakeStringManipulator.Setup(x => x.SerialNumberGenerator()).Returns(serialNumber);

            string uniqueKeyForSerialNumber = "uniqueKeyForSerialNumber";
            fakeStringManipulator.Setup(x => x.CreateGuid()).Returns(uniqueKeyForSerialNumber);

            OrderPartEmployee returnOrderPartEmployee = new OrderPartEmployee
            {
                OrderId = 1,
                Order = new Order(),
                SerialNumber = serialNumber,
                UniqueKeyForSerialNumber = uniqueKeyForSerialNumber,
                DateCreated = new DateTime(2024, 1, 1),
                OrdersPartsEmployeesInfos = new List<OrderPartEmployeeInfo>(),
                Part = new Part()
                {
                    Id = partId,
                    Name = testPartName,
                    SalePrice = partPrice,
                    Quantity = partQuantity
                },
                PartId = partId,
                PartName = testPartName,
                PartPrice = partPrice,
                PartQuantity = partQuantity
            };

            fakeOrdeFaktory.Setup(x => x.CreateOrderPartEmployeeProduct(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<decimal>(), It.IsAny<DateTime>())).Returns(returnOrderPartEmployee);

            var fakeOrderPartEmployeeDbSet = new Mock<DbSet<OrderPartEmployee>>();
            fakeContext.Setup(x => x.OrdersPartsEmployees).Returns(fakeOrderPartEmployeeDbSet.Object);

            int countOfAddedOrderPartEmployeeItems = 0;
            fakeOrderPartEmployeeDbSet.Setup(x => x.Add(It.IsAny<OrderPartEmployee>())).Callback(() => countOfAddedOrderPartEmployeeItems++);

            int countOfSaveChangesFromContext = 0;
            fakeContext.Setup(x => x.SaveChanges()).Callback(() => countOfSaveChangesFromContext++);

            //Act
            var actual = fakeOrderUserService.CreateOrderPartEmployeeByUserOrder(input.Object);

            int expectedCountOfAddedOrderPartEmployeeItems = 1;
            int expectedCountOfSaveChangesFromContext = 1;
            //Assert
            Assert.That(countOfAddedOrderPartEmployeeItems, Is.EqualTo(expectedCountOfAddedOrderPartEmployeeItems));
            Assert.That(countOfSaveChangesFromContext, Is.EqualTo(expectedCountOfSaveChangesFromContext));
        }
        [Test]
        public async Task DeleteOrder_ShouldReturnExactOneTimeSaveChanges()
        {
            //Arrange
            string userId = "userId";
            int orderId = 1;

            Order orderToBeDeleted = new Order
            {
                ClientId = userId,
                Id = orderId,
                StatusId = 1,
                IsDeleted = false,
                DateDeleted = null
            };
            fakeContext.Setup(x => x.Orders).ReturnsDbSet(new List<Order> { orderToBeDeleted });

            DateTime dateОfЕxtinction = new DateTime(2024, 1, 1);
            fakeDateTimeProvider.Setup(x => x.Now).Returns(dateОfЕxtinction);

            int countOfCallOfSaveChanges = 0;
            fakeContext.Setup(x => x.SaveChangesAsync(It.IsAny<CancellationToken>())).Callback(() => countOfCallOfSaveChanges++);

            //Act
            await fakeOrderUserService.DeleteOrder(userId, orderId);

            int expectedCountOfCallOfSaveChanges = 1;

            //Assert
            Assert.That(countOfCallOfSaveChanges, Is.EqualTo(expectedCountOfCallOfSaveChanges));
        }
        [Test]
        public async Task DeleteOrder_ShouldReturnCorrectProprtiesValues()
        {
            //Arrange
            string userId = "userId";
            int orderId = 1;

            Order orderToBeDeleted = new Order
            {
                ClientId = userId,
                Id = orderId,
                StatusId = 1,
                IsDeleted = false,
                DateDeleted = null
            };
            fakeContext.Setup(x => x.Orders).ReturnsDbSet(new List<Order> { orderToBeDeleted });

            DateTime dateОfЕxtinction = new DateTime(2024, 1, 1);
            fakeDateTimeProvider.Setup(x => x.Now).Returns(dateОfЕxtinction);

            //Act
            await fakeOrderUserService.DeleteOrder(userId, orderId);
            var deletedOrder = fakeContext.Object.Orders.FirstOrDefault();

            //Assert
            Assert.That(deletedOrder.DateDeleted, Is.EqualTo(dateОfЕxtinction));
            Assert.IsTrue(deletedOrder.IsDeleted);
        }

    }
}
