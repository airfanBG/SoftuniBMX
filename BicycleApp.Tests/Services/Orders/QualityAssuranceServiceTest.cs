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

        //[Test]
        //public async Task GetAllReadyOrder_ShouldReturnOrderList()
        //{
        //    //Arrange

        //    fakeContext.Setup(x => x.Orders).ReturnsDbSet(new List<Order>()
        //    {
        //        new Order()
        //        {
        //            SaleAmount = 75,
        //            StatusId = 5,
        //            ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
        //            Discount = 10,
        //            Id = 1,
        //            DateCreated = new DateTime(2023,12,16,7,45,22,625),
        //            FinalAmount = 90,
        //            VAT = 15,
        //            PaidAmount = 18,
        //            UnpaidAmount = 72,
        //            IsDeleted = false,
        //            Status = new Status(){ DateCreated = It.IsAny<DateTime>(), Id = 5, Name = It.IsAny<string>()},
        //            DateFinish = null,
        //            OrdersPartsEmployees = new List<OrderPartEmployee>
        //                                       {
        //                                            new OrderPartEmployee()
        //                                            {
        //                                                SerialNumber = "BID12345678",
        //                                                StartDatetime = new DateTime(2023,12,16,7,44,22,625),
        //                                                UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
        //                                                DateCreated = new DateTime(2023,12,16,7,45,22,625),
        //                                                DateFinish = new DateTime(2023,12,16,7,50,22,625),
        //                                                DatetimeAsigned = new DateTime(2023,12,16,7,30,22,625),
        //                                                EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
        //                                                IsCompleted = true,
        //                                                EndDatetime = new DateTime(2023,12,16,7,48,22,625),
        //                                                IsDeleted = false,
        //                                                OrderId = 1,
        //                                                PartId = 1,
        //                                                Order = new Order(),
        //                                                Part = new Part(),
        //                                                PartName = "sadas",
        //                                                PartPrice = 13.21M,
        //                                                PartQuantity = 1,
        //                                                OrdersPartsEmployeesInfos = new List<OrderPartEmployeeInfo>
        //                                                                            {
        //                                                                                new OrderPartEmployeeInfo()
        //                                                                                {
        //                                                                                    UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
        //                                                                                    Id = 1,
        //                                                                                    DescriptionForWorker = "",
        //                                                                                    OrderId = 1,
        //                                                                                    PartId = 1,
        //                                                                                    ProductionТime = new TimeSpan(0,2,0),
        //                                                                                    OrderPartEmployee = new OrderPartEmployee()                                                                                            
        //                                                                                }
        //                                                                             }
        //                                            }                
        //            }
        //         }
        //    });

        //    fakeContext.Setup(x => x.OrdersPartsEmployees).ReturnsDbSet(new List<OrderPartEmployee>
        //    {
        //        new OrderPartEmployee()
        //        {
        //            SerialNumber = "BID12345678",
        //            StartDatetime = new DateTime(2023,12,16,7,44,22,625),
        //            UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
        //            DateCreated = new DateTime(2023,12,16,7,45,22,625),
        //            DateFinish = new DateTime(2023,12,16,7,50,22,625),
        //            DatetimeAsigned = new DateTime(2023,12,16,7,30,22,625),
        //            EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
        //            IsCompleted = true,
        //            EndDatetime = new DateTime(2023,12,16,7,48,22,625),
        //            IsDeleted = false,
        //            OrderId = 1,
        //            PartId = 1
        //        },
        //        new OrderPartEmployee()
        //        {
        //            SerialNumber = "BID12345678",
        //            StartDatetime = new DateTime(2023,12,16,7,44,22,625),
        //            UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
        //            DateCreated = new DateTime(2023,12,16,7,45,22,625),
        //            DateFinish = new DateTime(2023,12,16,7,50,22,625),
        //            DatetimeAsigned = new DateTime(2023,12,16,7,30,22,625),
        //            EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
        //            IsCompleted = false,
        //            EndDatetime = new DateTime(2023,12,16,7,48,22,625),
        //            IsDeleted = false,
        //            OrderId = 1,
        //            PartId = 2
        //        }
        //    });

        //    fakeContext.Setup(x => x.OrdersPartsEmployeesInfos).ReturnsDbSet(new List<OrderPartEmployeeInfo>
        //    {
        //        new OrderPartEmployeeInfo()
        //        {
        //            UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
        //            Id = 1,
        //            DescriptionForWorker = "",
        //            OrderId = 1,
        //            PartId = 1,
        //            ProductionТime = new TimeSpan(0,2,0)
        //        }
        //    });
        //    fakeContext.Setup(x => x.Parts).ReturnsDbSet(new List<Part>
        //    {
        //        new Part()
        //            {
        //                Id = 1,
        //                Name = "Frame Road",
        //                Description = "Best frame in the road!",
        //                Intend = "For road usage",
        //                OEMNumber = "oemtest1",
        //                Type = 1,
        //                CategoryId = 1,
        //                Quantity = 32,
        //                SalePrice = 100.00M,
        //                Discount = 10.00M,
        //                VATCategoryId = 1,
        //                DateCreated = new DateTime(2023,1,1),
        //                DateUpdated = null,
        //                DateDeleted = null,
        //                IsDeleted = false
        //            },
        //        new Part()
        //            {
        //                Id = 2,
        //                Name = "Frame Road",
        //                Description = "Best frame in the road!",
        //                Intend = "For road usage",
        //                OEMNumber = "oemtest1",
        //                Type = 1,
        //                CategoryId = 1,
        //                Quantity = 32,
        //                SalePrice = 100.00M,
        //                Discount = 10.00M,
        //                VATCategoryId = 1,
        //                DateCreated = new DateTime(2023,1,1),
        //                DateUpdated = null,
        //                DateDeleted = null,
        //                IsDeleted = false
        //            }
        //    });
        //    fakeContext.Setup(x => x.Employees).ReturnsDbSet(new List<Employee>
        //    {
        //        new Employee()
        //        {
        //            Id = "21003785-a275-4139-ae20-af6a6cf8fea8",
        //            Email = "marinov@b-free.com",
        //            UserName = "marinov@b-free.com",
        //            NormalizedEmail = "marinov@b-free.com".ToUpper(),
        //            SecurityStamp = "marinov@b-free.com".ToUpper(),
        //            FirstName = "Marin",
        //            LastName = "Marinov",
        //            PhoneNumber = "1234567890",
        //            Position = "FrameWorker",
        //            DateOfHire = new DateTime(2023,1,1),
        //            DateCreated = new DateTime(2023,1,1),
        //            DateUpdated = null,
        //            DateOfLeave = null,
        //            IsDeleted = false,
        //            DepartmentId = 2,
        //            IsManeger = false,
        //            EmailConfirmed = true,
        //            BaseSalary = 1500,
        //            InternshipInMonths = 42
        //        }
        //     });
        //    var fakeOrderPartsEmployeeDbSet = new Mock<DbSet<OrderPartEmployee>>();
        //    var fakeOrderPartEmployeeInfoDbSet = new Mock<DbSet<OrderPartEmployeeInfo>>();
        //    var fakePartoDbSet = new Mock<DbSet<Part>>();
        //    var fakeEmployeeDbSet = new Mock<DbSet<Employee>>();
        //    fakeContext.Setup(x => x.OrdersPartsEmployees).Returns(fakeOrderPartsEmployeeDbSet.Object);
        //    fakeContext.Setup(x => x.OrdersPartsEmployeesInfos).Returns(fakeOrderPartEmployeeInfoDbSet.Object);
        //    fakeContext.Setup(x => x.Parts).Returns(fakePartoDbSet.Object);
        //    fakeContext.Setup(x => x.Employees).Returns(fakeEmployeeDbSet.Object);

        //    // Act
        //    var actual = await fakeQualityAssuranceService.GetAllReadyOrder();
        //    var actualOrderCount = actual.Count;

        //    int expectedOrderCount = 1;
        //    // Assert
        //    Assert.AreEqual(expectedOrderCount, actualOrderCount);
        //}

        [Test]
        public async Task OrderPassQualityAssurance_Should_ReturnIdOfPassedOrder()
        {
            // Arrange            
            int passedOrderId = 10;

            // Act
            var result = await fakeQualityAssuranceService.OrderPassQualityAssurance(passedOrderId);

            // Assert
            Assert.AreEqual(result, passedOrderId);
        }

        [Test]
        public async Task OrderPassQualityAssurance_Should_ReturnZeroWhenOrderIdIsInvalid()
        {
            // Arrange            
            int invalidOrderId = 100;

            // Act
            var result = await fakeQualityAssuranceService.OrderPassQualityAssurance(invalidOrderId);

            // Assert
            Assert.AreEqual(result, 0);
        }

        [Test]
        public async Task RemanufacturingPart_Should_ReturnedPartInfo()
        {
            // Arrange
            var fakeOrderProgretionDto = new Mock<IOrderProgretionDto>();
            fakeOrderProgretionDto.SetupGet(dto => dto.OrderId).Returns(1);

            var fakeOrderState = new OrderStateDto
            {
                PartId = 1,
                IsProduced = false,
                Description = "Test Description"
            };
            fakeOrderProgretionDto.SetupGet(dto => dto.OrderStates).Returns(new List<OrderStateDto> { fakeOrderState });

            fakeStringManipulator.Setup(x => x.ReturnFullName(It.IsAny<string>(), It.IsAny<string>()))
                .Returns((string firstName, string lastName) => $"{firstName} {lastName}");


            // Act
            var result = await fakeQualityAssuranceService.RemanufacturingPart(fakeOrderProgretionDto.Object);

            // Assert


        }
    }
}
