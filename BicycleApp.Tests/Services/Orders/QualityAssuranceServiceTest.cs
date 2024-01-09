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
        public async Task GetAllReadyOrder_Should_ReturnOrderList()
        {
            //Arrange

            fakeContext.Setup(x => x.Orders).ReturnsDbSet(new List<Order>() 
            {
                new Order()
                {
                    SaleAmount = 75,
                    StatusId = 5,
                    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                    Discount = 10,
                    Id = 1,
                    DateCreated = new DateTime(2023,12,16,7,45,22,625),
                    FinalAmount = 90,
                    VAT = 15,
                    PaidAmount = 18,
                    UnpaidAmount = 72,
                    IsDeleted = false,
                    Status = new Status(){ DateCreated = It.IsAny<DateTime>(), Id = 5, Name = It.IsAny<string>()},
                    DateFinish = null,
                    Client = new Client()
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
                         Balance = 1000.00M,
                         IsDeleted = false,
                         DateCreated = new DateTime(2023,1,1),
                         DateUpdated = null,
                         DateDeleted = null,
                         EmailConfirmed = true
                    },
                    OrdersPartsEmployees = new List<OrderPartEmployee>()
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
                                                   IsCompleted = true,
                                                   EndDatetime = new DateTime(2023,12,16,7,48,22,625),
                                                   IsDeleted = false,
                                                   OrderId = 1,
                                                   Part = new Part()
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
                                                       Discount = 10.00M,
                                                       VATCategoryId = 1,
                                                       DateCreated = new DateTime(2023,1,1),
                                                       DateUpdated = null,
                                                       DateDeleted = null,
                                                       IsDeleted = false
                                                   },
                                                   OrdersPartsEmployeesInfos = new List<OrderPartEmployeeInfo>()
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
        },
                //new Order()
                //{
                //    SaleAmount = 75,
                //    StatusId = 7,
                //    ClientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                //    Discount = 10,
                //    Id = 2,
                //    DateCreated = new DateTime(2023,12,16,7,45,22,625),
                //    FinalAmount = 90,
                //    VAT = 15,
                //    PaidAmount = 18,
                //    UnpaidAmount = 72,
                //    IsDeleted = false,
                //    OrdersPartsEmployees = new List<OrderPartEmployee>()
                //                           {
                //                               new OrderPartEmployee()
                //                               {
                //                                   SerialNumber = "BID12345678",
                //                                   StartDatetime = new DateTime(2023,12,16,7,44,22,625),
                //                                   UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
                //                                   DateCreated = new DateTime(2023,12,16,7,45,22,625),
                //                                   DateFinish = new DateTime(2023,12,16,7,50,22,625),
                //                                   DatetimeAsigned = new DateTime(2023,12,16,7,30,22,625),
                //                                   EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
                //                                   IsCompleted = false,
                //                                   EndDatetime = new DateTime(2023,12,16,7,48,22,625),
                //                                   IsDeleted = false,
                //                                   OrderId = 1,
                //                                   OrdersPartsEmployeesInfos = new List<OrderPartEmployeeInfo>()
                //                                   {
                //                                       new OrderPartEmployeeInfo()
                //                                       {
                //                                           UniqueKeyForSerialNumber = "50fc8043-9124-467c-b3e0-efbf5d2cc95b",
                //                                           Id = 1,
                //                                           DescriptionForWorker = "",
                //                                           OrderId = 1,
                //                                           PartId = 1,
                //                                           ProductionТime = new TimeSpan(0,2,0)
                //                                       }
                //                                   }
                //                               }
                //                           }
                //}
            });

            var fakeOrderProgretionDto = new Mock<IOrderProgretionDto>();
            fakeOrderProgretionDto.Object.OrderId = 1;
            fakeOrderProgretionDto.Object.DateCreated = "2023-12-16T07:44:22.625Z";
            fakeOrderProgretionDto.Object.SerialNumber = "";
            fakeOrderProgretionDto.Object.OrderStates = new List<OrderStateDto>()
                                                        {
                                                            new OrderStateDto()
                                                            {
                                                                SerialNumber = "BID12345678",
                                                                StartDate = "2023-12-16T07:44:22.625Z",
                                                                EmployeeId = "21003785-a275-4139-ae20-af6a6cf8fea8",
                                                                EndDate = "2023-12-16T07:48:22.625Z",
                                                                IsProduced = false,
                                                                Description = "return",
                                                                PartId = 1,
                                                                PartModel = "Frame Road",
                                                                NameOfEmplоyeeProducedThePart = "Marin Marinov",
                                                                PartQuantity = 1,
                                                                PartType = "Frame",
                                                                ElementProduceTimeInMinutes = 2
                                                            }
                                                        };            

            // Act
            var result = await fakeQualityAssuranceService.GetAllReadyOrder();

            // Assert
            Assert.IsNotNull(result);
        }

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
