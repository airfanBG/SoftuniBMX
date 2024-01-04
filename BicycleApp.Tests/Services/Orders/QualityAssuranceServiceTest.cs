namespace BicycleApp.Tests.Services.Orders
{
    using BicicleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.HelperClasses.Contracts;
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Models.Order.OrderUser;
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using BicycleApp.Services.Services.Orders;
    using BicycleApp.Tests.SeedData;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Moq.EntityFrameworkCore;

    public class QualityAssuranceServiceTest
    {
        private static readonly Mock<BicycleAppDbContext> fakeContext = new Mock<BicycleAppDbContext>();
        private static readonly Mock<IStringManipulator> fakeStringManipulator = new Mock<IStringManipulator>();
        private static readonly Mock<IDateTimeProvider> fakeDateTimeProvider = new Mock<IDateTimeProvider>();
        private static readonly Mock<IEmployeeFactory> fakeEmployeeFactory = new Mock<IEmployeeFactory>();

        private IQualityAssuranceService fakeQualityAssuranceService; 

        [OneTimeSetUp]
        public void SetUp()
        {
            var seeder = new SeedClass();

            fakeDateTimeProvider.Setup(x => x.Now).Returns(new DateTime(2023, 11, 11, 11, 11, 00));
            fakeEmployeeFactory.Setup(x => x.CreateRemanufacturingOrderPart(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns((string employeeName, string partName, string serialNumber, string description) =>
                    new RemanufacturingPartEmployeeInfoDto
                    {
                        EmployeeName = employeeName,
                        PartName = partName,
                        SerialNumber = serialNumber,
                        Description = description
                    });

            fakeContext.Setup(x => x.Clients)
                .ReturnsDbSet(seeder.SeedClients());
            fakeContext.Setup(x => x.Employees)
                .ReturnsDbSet(seeder.SeedEmployees());
            fakeContext.Setup(x => x.Comments)
                .ReturnsDbSet(seeder.SeedComments());
            fakeContext.Setup(x => x.Delivaries)
                .ReturnsDbSet(seeder.SeedDelivaries());
            fakeContext.Setup(x => x.Departments)
                .ReturnsDbSet(seeder.SeedDepartments());
            fakeContext.Setup(x => x.ImagesParts)
                .ReturnsDbSet(seeder.SeedImagesParts());
            fakeContext.Setup(x => x.ImagesClients)
                .ReturnsDbSet(seeder.SeedImagesClients());
            fakeContext.Setup(x => x.ImagesEmployees)
                .ReturnsDbSet(seeder.SeedImagesEmployees());
            fakeContext.Setup(x => x.Orders)
                .ReturnsDbSet(seeder.SeedOrders());
            fakeContext.Setup(x => x.OrdersPartsEmployees)
                .ReturnsDbSet(seeder.SeedOrdersPartsEmployees());
            fakeContext.Setup(x => x.OrdersPartsEmployeesInfos)
                .ReturnsDbSet(seeder.SeedOrderOrderParsEmployeeInfos());
            fakeContext.Setup(x => x.Parts)
                .ReturnsDbSet(seeder.SeedParts());
            fakeContext.Setup(x => x.PartCategories)
                .ReturnsDbSet(seeder.SeedPartCategories());
            fakeContext.Setup(x => x.Rates)
                .ReturnsDbSet(seeder.SeedRates());
            fakeContext.Setup(x => x.Statuses)
                .ReturnsDbSet(seeder.SeedStatuses());
            fakeContext.Setup(x => x.Supliers)
                .ReturnsDbSet(seeder.SeedSuplieres());
            fakeContext.Setup(x => x.Towns)
                .ReturnsDbSet(seeder.SeedTowns());
            fakeContext.Setup(x => x.DelivaryAddresses)
                .ReturnsDbSet(seeder.SeedDelivaryAddresses());
            fakeContext.Setup(x => x.VATCategories)
                .ReturnsDbSet(seeder.SeedVATCategories());
            fakeContext.Setup(x => x.PartsInStock)
                .ReturnsDbSet(seeder.SeedPartsInStock());
            fakeContext.Setup(x => x.PartOrders)
                .ReturnsDbSet(seeder.SeedPartOrders());
            fakeContext.Setup(x => x.BaseUserRoles)
                .ReturnsDbSet(seeder.SeedRoles());
            fakeContext.Setup(x => x.UserRoles)
                .ReturnsDbSet(seeder.SeedRolesUsers());
            fakeContext.Setup(x => x.BikesStandartModels)
                .ReturnsDbSet(seeder.SeedBikeStandartModels());
            fakeContext.Setup(x => x.BikeModelsParts)
                .ReturnsDbSet(seeder.SeedBikeModelPartls());

            fakeQualityAssuranceService = new QualityAssuranceService(fakeContext.Object, fakeStringManipulator.Object, fakeDateTimeProvider.Object, fakeEmployeeFactory.Object);
        }

        [Test]
        public async Task GetAllReadyOrder_Should_ReturnOrderList()
        {
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
