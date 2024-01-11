namespace BicycleApp.Tests.Services
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Services;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Moq.EntityFrameworkCore;
    using System.Linq.Expressions;

    public class BikeServiceTest
    {
        private readonly Mock<BicycleAppDbContext> _fakeDbContext = new Mock<BicycleAppDbContext>();
        private readonly Mock<IModelsFactory> _fakeModelFactory = new Mock<IModelsFactory>();

        private readonly IBikeService _bikeService;

        public BikeServiceTest()
        {
            _bikeService = new BikeService(_fakeDbContext.Object, _fakeModelFactory.Object);
        }

        [Test]
        public async Task AddBikeModelAsync_ShouldReturnFalse_WhenNoParameters()
        {
            //Arrange
            BikeStandartTypeAddDto? emptyParameter = null;

            //Act
            var actual = await _bikeService.AddBikeModelAsync(emptyParameter);

            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public async Task AddBikeModelAsync_ShouldReturnTrue_WhenDataIsSavedInContext()
        {
            //Arrange
            BikeStandartTypeAddDto inputBike = new BikeStandartTypeAddDto
            {
                Description = "Test description",
                ImageUrl = "https://testurl.com/test/test.jpg",
                ModelName = "Test name",
                Price = 158.58M
            };

            Part firstPart = new Part
            {
                SalePrice = 123.12M,
                CategoryId = 1,
                Id = 1,
                OEMNumber = "Test OEM number"
            };

            HashSet<BikeModelPart> bikeModelParts = new HashSet<BikeModelPart>
            {
                new BikeModelPart
                {
                    BikeModelId = 1,
                    PartId=1,
                },
            };

            BikeStandartModel? testBike = new BikeStandartModel
            {
                Id = 1,
                Description = "Test description",
                ImageUrl = "https://testurl.com/test/test.jpg",
                ModelName = "Test name",
                Price = 158.58M,
                DateCreated = new DateTime(2024, 1, 1),
                BikeModelsParts = bikeModelParts
            };

            var bikeStandartModelsDbSetMock = new Mock<DbSet<BikeStandartModel>>();
            var bikeModelPartsDbSet = new Mock<DbSet<BikeModelPart>>();
            _fakeDbContext.Setup(x => x.BikesStandartModels).Returns(bikeStandartModelsDbSetMock.Object);
            _fakeDbContext.Setup(x => x.BikeModelsParts).Returns(bikeModelPartsDbSet.Object);

            var modelFactoryObject = _fakeModelFactory.Setup(x => x.CreateNewBikeStandartModel(It.IsAny<BikeStandartTypeAddDto>())).Returns(testBike);

            //Act
            var actual = await _bikeService.AddBikeModelAsync(inputBike);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public async Task AddBikeModelAsync_ShouldReturnExactTimeOfExecution_WhenDataIsSavedInContext()
        {
            // Arrange
            
            BikeStandartTypeAddDto inputBike = new BikeStandartTypeAddDto
            {
                Description = "Test description",
                ImageUrl = "https://testurl.com/test/test.jpg",
                ModelName = "Test name",
                Price = 158.58M
            };
            Part firstPart = new Part
            {
                SalePrice = 123.12M,
                CategoryId = 1,
                Id = 1,
                OEMNumber = "Test OEM number"
            };

            HashSet<BikeModelPart> bikeModelParts = new HashSet<BikeModelPart>
            {
                new BikeModelPart
                {
                    BikeModelId = 1,
                    PartId=1,
                },
            };

            BikeStandartModel? testBike = new BikeStandartModel
            {
                Id = 1,
                Description = "Test description",
                ImageUrl = "https://testurl.com/test/test.jpg",
                ModelName = "Test name",
                Price = 158.58M,
                DateCreated = new DateTime(2024, 1, 1),
                BikeModelsParts = bikeModelParts
            };
            int actualCalledFunction = 0;

            var bikeStandartModelsDbSetMock = new Mock<DbSet<BikeStandartModel>>();
            var bikeModelPartsDbSet = new Mock<DbSet<BikeModelPart>>();
            _fakeDbContext.Setup(x => x.BikesStandartModels).Returns(bikeStandartModelsDbSetMock.Object);
            _fakeDbContext.Setup(x => x.BikeModelsParts).Returns(bikeModelPartsDbSet.Object);

            var modelFactoryObject = _fakeModelFactory.Setup(x => x.CreateNewBikeStandartModel(It.IsAny<BikeStandartTypeAddDto>())).Returns(testBike);

            bikeStandartModelsDbSetMock.Setup(x => x.AddAsync(It.IsAny<BikeStandartModel>(), It.IsAny<CancellationToken>()))
                .Callback(() => actualCalledFunction++);
            
            // Act
            var actual = await _bikeService.AddBikeModelAsync(inputBike);
            int expectedFunctionCalled = 1;
            // Assert
            Assert.AreEqual(expectedFunctionCalled, actualCalledFunction);
        }

        [Test]
        public async Task AddBikeModelAsync_ShouldReturnExactTimeOfExecutionOfAddingParts_WhenDataIsSavedInContext()
        {
            // Arrange

            BikeStandartTypeAddDto inputBike = new BikeStandartTypeAddDto
            {
                Description = "Test description",
                ImageUrl = "https://testurl.com/test/test.jpg",
                ModelName = "Test name",
                Price = 158.58M
            };
            Part firstPart = new Part
            {
                SalePrice = 123.12M,
                CategoryId = 1,
                Id = 1,
                OEMNumber = "Test OEM number"
            };

            HashSet<BikeModelPart> bikeModelParts = new HashSet<BikeModelPart>
            {
                new BikeModelPart
                {
                    BikeModelId = 1,
                    PartId=1,
                },
            };

            BikeStandartModel? testBike = new BikeStandartModel
            {
                Id = 1,
                Description = "Test description",
                ImageUrl = "https://testurl.com/test/test.jpg",
                ModelName = "Test name",
                Price = 158.58M,
                DateCreated = new DateTime(2024, 1, 1),
                BikeModelsParts = bikeModelParts
            };
            int actualCalledFunction = 0;

            var bikeStandartModelsDbSetMock = new Mock<DbSet<BikeStandartModel>>();
            var bikeModelPartsDbSet = new Mock<DbSet<BikeModelPart>>();
            var partDbSet = new Mock<DbSet<Part>>();
            _fakeDbContext.Setup(x => x.BikesStandartModels).Returns(bikeStandartModelsDbSetMock.Object);
            _fakeDbContext.Setup(x => x.BikeModelsParts).Returns(bikeModelPartsDbSet.Object);
            _fakeDbContext.Setup(x => x.Parts).Returns(partDbSet.Object);

            var modelFactoryObject = _fakeModelFactory.Setup(x => x.CreateNewBikeStandartModel(It.IsAny<BikeStandartTypeAddDto>())).Returns(testBike);

            partDbSet.Setup(x => x.FirstOrDefaultAsync(It.IsAny<Expression<Func<Part, bool>>>(), It.IsAny<CancellationToken>())).ReturnsAsync(Mock.Of<Part>);
            
            bikeModelPartsDbSet.Setup(x => x.AddAsync(It.IsAny<BikeModelPart>(), It.IsAny<CancellationToken>()))
            .Callback(() => actualCalledFunction++);

            // Act
            var actual = await _bikeService.AddBikeModelAsync(inputBike);
            int expectedFunctionCalled = 1;

            // Assert
            Assert.AreEqual(expectedFunctionCalled, actualCalledFunction);
        }
    }
}
