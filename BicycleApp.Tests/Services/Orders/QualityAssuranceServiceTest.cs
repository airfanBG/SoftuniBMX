namespace BicycleApp.Tests.Services.Orders
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using BicycleApp.Services.Services.Orders;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Moq.EntityFrameworkCore;

    public class QualityAssuranceServiceTest
    {
        private static readonly Mock<BicycleAppDbContext> fakeContext = new Mock<BicycleAppDbContext>();
        private static readonly Mock<IStringManipulator> fakeStringManipulator = new Mock<IStringManipulator>();
        private static readonly Mock<IDateTimeProvider> fakeDateTimeProvider = new Mock<IDateTimeProvider>();
        private static readonly Mock<IEmployeeFactory> fakeEmployeeFactory = new Mock<IEmployeeFactory>();

        private IQualityAssuranceService fakeQualityAssuranceService = new QualityAssuranceService(fakeContext.Object, fakeStringManipulator.Object, fakeDateTimeProvider.Object, fakeEmployeeFactory.Object);

        [Test]
        public async Task GetAllReadyOrder_ShouldReturnOrderThatAreReady()
        {
            //Arrange
            Order complitedOrder = new Order()
            {
                SaleAmount = 75,
                StatusId = 5,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Discount = 10,
                Id = 1,
                DateCreated = new DateTime(2023, 12, 16, 7, 45, 22, 625),
                FinalAmount = 90,
                VAT = 15,
                PaidAmount = 18,
                UnpaidAmount = 72,
                IsDeleted = false,
                Status = new Status() { DateCreated = It.IsAny<DateTime>(), Id = 5, Name = It.IsAny<string>() },
                DateFinish = null,
                OrdersPartsEmployees = new List<OrderPartEmployee>
                                               {
                                                    new OrderPartEmployee()
                                                    {
                                                        SerialNumber = "BID12345678",
                                                        StartDatetime = new DateTime(2023,12,16,7,44,22,625),
                                                        UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
                                                        DateCreated = new DateTime(2023,12,16,7,45,22,625),
                                                        DateFinish = new DateTime(2023,12,16,7,50,22,625),
                                                        DatetimeAsigned = new DateTime(2023,12,16,7,30,22,625),
                                                        EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
                                                        Employee = new Employee
                                                        {
                                                            Id = "21003785-a275-4139-ae20-af6a6cf8fea8",
                                                            Email = "marinov@b-free.com",
                                                            UserName = "marinov@b-free.com",
                                                            NormalizedEmail = "marinov@b-free.com".ToUpper(),
                                                            SecurityStamp = "marinov@b-free.com".ToUpper(),
                                                            FirstName = "Marin",
                                                            LastName = "Marinov",
                                                            PhoneNumber = "1234567890",
                                                            Position = "FrameWorker",
                                                            DateOfHire = new DateTime(2023,1,1),
                                                            DateCreated = new DateTime(2023,1,1),
                                                            DateUpdated = null,
                                                            DateOfLeave = null,
                                                            IsDeleted = false,
                                                            DepartmentId = 2,
                                                            IsManeger = false,
                                                            EmailConfirmed = true,
                                                            BaseSalary = 1500,
                                                            InternshipInMonths = 42
                                                        },
                                                        IsCompleted = true,
                                                        EndDatetime = new DateTime(2023,12,16,7,48,22,625),
                                                        IsDeleted = false,
                                                        OrderId = 1,
                                                        PartId = 1,
                                                        Order = new Order(),
                                                        Part = new Part()
                                                        {
                                                            Id = 1,
                                                            Name = "Frame Road",
                                                            Description = "Best frame in the road!",
                                                            Intend = "For road usage",
                                                            OEMNumber = "oemtest1",
                                                            Type = 1,
                                                            CategoryId = 1,
                                                            Category = new PartCategory
                                                            {
                                                               Id = 1,
                                                               Name = "Frame",
                                                               ImageUrl = "test",
                                                               DateCreated = new DateTime(2023,1,1)
                                                            },
                                                            Quantity = 32,
                                                            SalePrice = 100.00M,
                                                            Discount = 10.00M,
                                                            VATCategoryId = 1,
                                                            DateCreated = new DateTime(2023,1,1)
                                                        },
                                                        PartName = "Frame Road",
                                                        PartPrice = 90.00M,
                                                        PartQuantity = 1,
                                                        OrdersPartsEmployeesInfos = new List<OrderPartEmployeeInfo>
                                                                                    {
                                                                                        new OrderPartEmployeeInfo()
                                                                                        {
                                                                                            UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
                                                                                            Id = 1,
                                                                                            DescriptionForWorker = "",
                                                                                            OrderId = 1,
                                                                                            PartId = 1,
                                                                                            ProductionТime = new TimeSpan(0,2,0)
                                                                                        }
                                                                                     }
                                                    }
                    }
            };
            Order notComplitedOrder = new Order()
            {
                SaleAmount = 75,
                StatusId = 5,
                ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                Discount = 10,
                Id = 2,
                DateCreated = new DateTime(2023, 12, 16, 7, 45, 22, 625),
                FinalAmount = 90,
                VAT = 15,
                PaidAmount = 18,
                UnpaidAmount = 72,
                IsDeleted = false,
                Status = new Status() { DateCreated = It.IsAny<DateTime>(), Id = 5, Name = It.IsAny<string>() },
                DateFinish = null,
                OrdersPartsEmployees = new List<OrderPartEmployee>
                                               {
                                                    new OrderPartEmployee()
                                                    {
                                                        SerialNumber = "BID12345678",
                                                        StartDatetime = new DateTime(2023,12,16,7,44,22,625),
                                                        UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
                                                        DateCreated = new DateTime(2023,12,16,7,45,22,625),
                                                        DateFinish = new DateTime(2023,12,16,7,50,22,625),
                                                        DatetimeAsigned = new DateTime(2023,12,16,7,30,22,625),
                                                        EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
                                                        Employee = new Employee
                                                        {
                                                            Id = "21003785-a275-4139-ae20-af6a6cf8fea8",
                                                            Email = "marinov@b-free.com",
                                                            UserName = "marinov@b-free.com",
                                                            NormalizedEmail = "marinov@b-free.com".ToUpper(),
                                                            SecurityStamp = "marinov@b-free.com".ToUpper(),
                                                            FirstName = "Marin",
                                                            LastName = "Marinov",
                                                            PhoneNumber = "1234567890",
                                                            Position = "FrameWorker",
                                                            DateOfHire = new DateTime(2023,1,1),
                                                            DateCreated = new DateTime(2023,1,1),
                                                            DateUpdated = null,
                                                            DateOfLeave = null,
                                                            IsDeleted = false,
                                                            DepartmentId = 2,
                                                            IsManeger = false,
                                                            EmailConfirmed = true,
                                                            BaseSalary = 1500,
                                                            InternshipInMonths = 42
                                                        },
                                                        IsCompleted = false,
                                                        EndDatetime = new DateTime(2023,12,16,7,48,22,625),
                                                        IsDeleted = false,
                                                        OrderId = 2,
                                                        PartId = 1,
                                                        Order = new Order(),
                                                        Part = new Part()
                                                        {
                                                            Id = 1,
                                                            Name = "Frame Road",
                                                            Description = "Best frame in the road!",
                                                            Intend = "For road usage",
                                                            OEMNumber = "oemtest1",
                                                            Type = 1,
                                                            CategoryId = 1,
                                                            Category = new PartCategory
                                                            {
                                                               Id = 1,
                                                               Name = "Frame",
                                                               ImageUrl = "test",
                                                               DateCreated = new DateTime(2023,1,1)
                                                            },
                                                            Quantity = 32,
                                                            SalePrice = 100.00M,
                                                            Discount = 10.00M,
                                                            VATCategoryId = 1,
                                                            DateCreated = new DateTime(2023,1,1)
                                                        },
                                                        PartName = "Frame Road",
                                                        PartPrice = 90.00M,
                                                        PartQuantity = 1,
                                                        OrdersPartsEmployeesInfos = new List<OrderPartEmployeeInfo>
                                                                                    {
                                                                                        new OrderPartEmployeeInfo()
                                                                                        {
                                                                                            UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
                                                                                            Id = 1,
                                                                                            DescriptionForWorker = "",
                                                                                            OrderId = 2,
                                                                                            PartId = 1,
                                                                                            ProductionТime = new TimeSpan(0,2,0)
                                                                                        }
                                                                                     }
                                                    }
                    }
            };

            List<Order> orders = new List<Order>();
            orders.Add(complitedOrder);
            orders.Add(notComplitedOrder);

            fakeContext.Setup(x => x.Orders).ReturnsDbSet(orders);

            // Act
            var actual = await fakeQualityAssuranceService.GetAllReadyOrder();
            var actualOrderCount = actual.Count;

            int expectedOrderCount = 1;

            // Assert
            Assert.That(actualOrderCount, Is.EqualTo(expectedOrderCount));
        }

        [Test]
        public async Task OrderPassQualityAssurance_ShouldReturnIdOfPassedOrder()
        {
            // Arrange            
            Order seedOrder = new Order
            {
                Id = 1,
                StatusId = 6,
                OrdersPartsEmployees = new List<OrderPartEmployee>{ new OrderPartEmployee() }
            };
            fakeContext.Setup(x => x.Orders).ReturnsDbSet(new List<Order> { seedOrder });

            int passedOrderId = 1;
            // Act
            var result = await fakeQualityAssuranceService.OrderPassQualityAssurance(passedOrderId);

            // Assert
            Assert.That(passedOrderId, Is.EqualTo(result));
        }

        [Test]
        public async Task OrderPassQualityAssurance_ShouldReturnZeroWhenOrderIdIsInvalid()
        {
            // Arrange            
            int invalidOrderId = 100;

            // Act
            var result = await fakeQualityAssuranceService.OrderPassQualityAssurance(invalidOrderId);

            // Assert
            Assert.AreEqual(result, 0);
        }

        [Test]
        public async Task RemanufacturingPart_ShouldReturnedCorrctCount()
        {
            // Arrange
            OrderPartEmployee seedData = new OrderPartEmployee
            {
                OrderId = 1,
                PartId = 1,
                Employee = new Employee
                {
                    Id = "21003785-a275-4139-ae20-af6a6cf8fea8",
                    FirstName = "Marin",
                    LastName = "Marinov",
                    PhoneNumber = "1234567890",
                    Position = "FrameWorker"
                },
                OrdersPartsEmployeesInfos = new List<OrderPartEmployeeInfo>
                                            {
                                                new OrderPartEmployeeInfo
                                                {
                                                    Id = 1,
                                                    OrderId = 1,
                                                    PartId = 1,
                                                    ProductionТime = new TimeSpan(0,2,0),
                                                }
                                            }
            };

            fakeContext.Setup(x => x.OrdersPartsEmployees).ReturnsDbSet(new List<OrderPartEmployee> { seedData } );

            List<OrderStateDto> orderStates = new List<OrderStateDto>
            {
                new OrderStateDto
                {
                    SerialNumber = "BIDTEST",
                    StartDate = "2009-06-15T13:45:30",
                    PartId = 1,
                    Description = "Make better test",
                    IsProduced = false,
                }
            };
            var fakeOrderProgretionDto = new Mock<IOrderProgretionDto>();
            fakeOrderProgretionDto.SetupGet(dto => dto.OrderId).Returns(1);
            fakeOrderProgretionDto.SetupGet(dto => dto.DateCreated).Returns("2009-06-15T13:45:30");
            fakeOrderProgretionDto.SetupGet(dto => dto.OrderStates).Returns(orderStates);

            
            fakeStringManipulator.Setup(x => x.ReturnFullName(It.IsAny<string>(), It.IsAny<string>()))
                .Returns((string firstName, string lastName) => $"{firstName} {lastName}");


            // Act
            var result = await fakeQualityAssuranceService.RemanufacturingPart(fakeOrderProgretionDto.Object);
            int expectedItemToRemanufacturing = 1;
            // Assert
            Assert.That(result.Count, Is.EqualTo(expectedItemToRemanufacturing));

        }
        [Test]
        public async Task RemanufacturingPart_ShouldReturnFalse_WhenPropertyChangeStatus()
        {
            // Arrange
            OrderPartEmployee seedData = new OrderPartEmployee
            {
                OrderId = 1,
                PartId = 1,
                IsCompleted = true,
                Employee = new Employee
                {
                    Id = "21003785-a275-4139-ae20-af6a6cf8fea8",
                    FirstName = "Marin",
                    LastName = "Marinov",
                    PhoneNumber = "1234567890",
                    Position = "FrameWorker"
                },
                OrdersPartsEmployeesInfos = new List<OrderPartEmployeeInfo>
                                            {
                                                new OrderPartEmployeeInfo
                                                {
                                                    Id = 1,
                                                    OrderId = 1,
                                                    PartId = 1,
                                                    ProductionТime = new TimeSpan(0,2,0),
                                                }
                                            }
            };

            fakeContext.Setup(x => x.OrdersPartsEmployees).ReturnsDbSet(new List<OrderPartEmployee> { seedData });

            List<OrderStateDto> orderStates = new List<OrderStateDto>
            {
                new OrderStateDto
                {
                    SerialNumber = "BIDTEST",
                    StartDate = "2009-06-15T13:45:30",
                    PartId = 1,
                    Description = "Make better test",
                    IsProduced = false,
                }
            };
            var fakeOrderProgretionDto = new Mock<IOrderProgretionDto>();
            fakeOrderProgretionDto.SetupGet(dto => dto.OrderId).Returns(1);
            fakeOrderProgretionDto.SetupGet(dto => dto.DateCreated).Returns("2009-06-15T13:45:30");
            fakeOrderProgretionDto.SetupGet(dto => dto.OrderStates).Returns(orderStates);


            fakeStringManipulator.Setup(x => x.ReturnFullName(It.IsAny<string>(), It.IsAny<string>()))
                .Returns((string firstName, string lastName) => $"{firstName} {lastName}");

            // Act
            var result = await fakeQualityAssuranceService.RemanufacturingPart(fakeOrderProgretionDto.Object);
            if (result.Count>0)
            {
                // Assert
                bool isPartComplite = fakeContext.Object.OrdersPartsEmployees.First(x => x.OrderId == seedData.OrderId).IsCompleted;
                Assert.False(isPartComplite);
            }

        }
    }
}
