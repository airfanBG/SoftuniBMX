namespace BicycleApp.Tests.Services.Bike
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Bike;
    using BicycleApp.Services.Services;
    using BicycleApp.Services.Services.Bike;
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

        //[Test]
        //public async Task AddBikeModelAsync_ShouldReturnExactTimeOfExecutionOfAddingParts_WhenDataIsSavedInContext()
        //{
        //    // Arrange

        //    Part firstPart = new Part
        //    {
        //        SalePrice = 123.12M,
        //        CategoryId = 1,
        //        Id = 1,
        //        OEMNumber = "Test OEM number"
        //    };

        //    BikeStandartTypeAddDto inputBike = new BikeStandartTypeAddDto
        //    {
        //        Description = "Test description",
        //        ImageUrl = "https://testurl.com/test/test.jpg",
        //        ModelName = "Test name",
        //        Price = 158.58M,
        //        Parts = new HashSet<int>() { 1 }
        //    };

        //    BikeModelPart singleBikeModelPart = new BikeModelPart
        //    {
        //        BikeModelId = 1,
        //        PartId = 1,
        //    };

        //    List<BikeModelPart> bikeModelParts = new List<BikeModelPart> { singleBikeModelPart };

        //    BikeStandartModel? testBike = new BikeStandartModel
        //    {
        //        Id = 1,
        //        Description = "Test description",
        //        ImageUrl = "https://testurl.com/test/test.jpg",
        //        ModelName = "Test name",
        //        Price = 158.58M,
        //        DateCreated = new DateTime(2024, 1, 1),
        //        BikeModelsParts = bikeModelParts
        //    };
        //    int actualCalledFunction = 0;

        //    var bikeStandartModelsDbSetMock = new Mock<DbSet<BikeStandartModel>>();
        //    var bikeModelPartsDbSet = new Mock<DbSet<BikeModelPart>>();
        //    var partDbSet = new Mock<DbSet<Part>>();
        //    _fakeDbContext.Setup(x => x.BikesStandartModels).Returns(bikeStandartModelsDbSetMock.Object);
        //    _fakeDbContext.Setup(x => x.BikeModelsParts).Returns(bikeModelPartsDbSet.Object);
        //    _fakeDbContext.Setup(x => x.Parts).Returns(partDbSet.Object);

        //    var modelFactoryObject = _fakeModelFactory.Setup(x => x.CreateNewBikeStandartModel(It.IsAny<BikeStandartTypeAddDto>())).Returns(testBike);
        //    _fakeDbContext.Setup(x => x.Parts).ReturnsDbSet(new List<Part> { firstPart });

        //    bikeModelPartsDbSet.Setup(x => x.AddRangeAsync(It.IsAny<BikeModelPart>()))
        //    .Callback(() => actualCalledFunction++);

        //    // Act
        //    var actual = await _bikeService.AddBikeModelAsync(inputBike);
        //    int expectedFunctionCalled = 1;

        //    // Assert
        //    Assert.AreEqual(expectedFunctionCalled, actualCalledFunction);
        //}
        [Test]
        public async Task EditBikeModelAsync_ShouldReturnFalse_WhenGetNullValue()
        {
            //Arrnage
            BikeStandartTypeEditDto nullValue = null;

            //Act
            var actual = await _bikeService.EditBikeModelAsync(nullValue);

            //Assert
            Assert.IsFalse(actual);
        }
        [Test]
        public async Task EditBikeModelAsync_ShouldReturnFalse_WhenBikeIdDonotExistInCollection()
        {
            //Arrnage
            BikeStandartTypeEditDto input = new BikeStandartTypeEditDto
            {
                Id = 4,
                Description = "Test description",
                ImageUrl = "https://test/bikes/bike-1.webp",
                ModelName = "Bike 1",
                Price = 575.00M
            };

            BikeStandartModel firstStandartBike = new BikeStandartModel()
            {
                Id = 1,
                ModelName = "Bike 1",
                ImageUrl = "https://test/bikes/bike-1.webp",
                Price = 575M,
                Description = "Slow Initial Rendering: Since the data is fetched from the server before rendering, initial load times can be slow, resulting in a less-than-ideal user experience."
            };

            _fakeDbContext.Setup(x => x.BikesStandartModels).ReturnsDbSet(new List<BikeStandartModel> { firstStandartBike });

            //Act
            var actual = await _bikeService.EditBikeModelAsync(input);

            //Assert
            Assert.IsFalse(actual);
        }
        [Test]
        public async Task EditBikeModelAsync_ShouldReturnEditedProperties()
        {
            //Arrnage
            BikeStandartTypeEditDto input = new BikeStandartTypeEditDto
            {
                Id = 1,
                Description = "Edited description",
                ImageUrl = "https://edited/bikes/bike-1.webp",
                ModelName = "Edited bike",
                Price = 247.00M
            };

            List<BikeModelPart> bikeModelParts = new List<BikeModelPart>
                                  {
                                        new BikeModelPart
                                        {
                                            BikeModelId = 1,
                                            PartId = 1
                                        },
                                        new BikeModelPart
                                        {
                                            BikeModelId = 1,
                                            PartId = 2
                                        }
                                  };

            BikeStandartModel firstStandartBike = new BikeStandartModel()
            {
                Id = 1,
                ModelName = "Bike 1",
                ImageUrl = "https://test/bikes/bike-1.webp",
                Price = 575M,
                Description = "Slow Initial Rendering: Since the data is fetched from the server before rendering, initial load times can be slow, resulting in a less-than-ideal user experience.",
                BikeModelsParts = bikeModelParts
            };

            var bikeModelPartDbSet = new Mock<DbSet<BikeModelPart>>();
            _fakeDbContext.Setup(x => x.BikesStandartModels).ReturnsDbSet(new List<BikeStandartModel> { firstStandartBike });
            _fakeDbContext.Setup(x => x.BikeModelsParts).ReturnsDbSet(bikeModelParts);

            //Act
            var actual = await _bikeService.EditBikeModelAsync(input);

            var editedObject = _fakeDbContext.Object.BikesStandartModels.First();

            //Assert
            Assert.AreEqual(input.Id, editedObject.Id);
            Assert.AreEqual(input.Description, editedObject.Description);
            Assert.AreEqual(input.ImageUrl, editedObject.ImageUrl);
            Assert.AreEqual(input.ModelName, editedObject.ModelName);
            Assert.AreEqual(input.Price, editedObject.Price);
        }

        [Test]
        public async Task EditBikeModelAsync_ShouldReturnTrue_WhenSuccessfulyEditEntity()
        {
            //Arrnage
            BikeStandartTypeEditDto input = new BikeStandartTypeEditDto
            {
                Id = 1,
                Description = "Edited description",
                ImageUrl = "https://edited/bikes/bike-1.webp",
                ModelName = "Edited bike",
                Price = 247.00M
            };

            List<BikeModelPart> bikeModelParts = new List<BikeModelPart>
                                  {
                                        new BikeModelPart
                                        {
                                            BikeModelId = 1,
                                            PartId = 1
                                        },
                                        new BikeModelPart
                                        {
                                            BikeModelId = 1,
                                            PartId = 2
                                        }
                                  };

            BikeStandartModel firstStandartBike = new BikeStandartModel()
            {
                Id = 1,
                ModelName = "Bike 1",
                ImageUrl = "https://test/bikes/bike-1.webp",
                Price = 575M,
                Description = "Slow Initial Rendering: Since the data is fetched from the server before rendering, initial load times can be slow, resulting in a less-than-ideal user experience.",
                BikeModelsParts = bikeModelParts
            };

            var bikeModelPartDbSet = new Mock<DbSet<BikeModelPart>>();
            _fakeDbContext.Setup(x => x.BikesStandartModels).ReturnsDbSet(new List<BikeStandartModel> { firstStandartBike });
            _fakeDbContext.Setup(x => x.BikeModelsParts).ReturnsDbSet(bikeModelParts);

            //Act
            var actual = await _bikeService.EditBikeModelAsync(input);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public async Task GetAllParts_ShouldReturnRightCountOfCollectionParts()
        {
            //Arrange
            var firstPart = new Part
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
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false
            };
            var secondPart = new Part
            {
                Id = 2,
                Name = "Frame Montain",
                Description = "Best frame in the montain",
                Intend = "For montain usage",
                OEMNumber = "oemtest2",
                Type = 2,
                CategoryId = 1,
                Quantity = 43,
                SalePrice = 90.00M,
                VATCategoryId = 1,
                DateCreated = new DateTime(2024, 1, 1),
                DateUpdated = null,
                DateDeleted = null,
                IsDeleted = false
            };

            _fakeDbContext.Setup(x => x.Parts).ReturnsDbSet(new List<Part> { firstPart, secondPart });

            //Act
            var actual = await _bikeService.GetAllParts();

            int expectedPartsCount = 2;
            int actualPartsCount = actual.Count;

            //Assert
            Assert.AreEqual(expectedPartsCount, actualPartsCount);
        }

        [Test]
        public async Task GetBikeModelAsync_ShouldReturnBikeStandartTypeEditDtoId_WhenIdMatches()
        {
            //Arrange
            BikeStandartModel firstStandartBike = new BikeStandartModel()
            {
                Id = 1,
                ModelName = "Bike 1",
                ImageUrl = "https://test/bikes/bike-1.webp",
                Price = 575M,
                Description = "Slow Initial Rendering: Since the data is fetched from the server before rendering, initial load times can be slow, resulting in a less-than-ideal user experience."
            };
            BikeStandartModel secondStandartBike = new BikeStandartModel()
            {
                Id = 2,
                ModelName = "Bike 2",
                ImageUrl = "https://test/bikes/bike-2.webp",
                Price = 365M,
                Description = "Loading States: Users may experience an in-between or loading state, as they wait for the data to be rendered on the page."
            };

            _fakeDbContext.Setup(x => x.BikesStandartModels).ReturnsDbSet(new List<BikeStandartModel> { firstStandartBike, secondStandartBike });

            //Act
            var actual = await _bikeService.GetBikeModelAsync(firstStandartBike.Id);

            //Assert
            Assert.AreEqual(firstStandartBike.Id, actual.Id);
            Assert.AreNotEqual(secondStandartBike.Id, actual.Id);
        }

        [Test]
        public async Task GetBikeModelAsync_ShouldReturnNull_WhenThereIsNoIdinCollection()
        {
            //Arrange
            BikeStandartModel firstStandartBike = new BikeStandartModel()
            {
                Id = 1,
                ModelName = "Bike 1",
                ImageUrl = "https://test/bikes/bike-1.webp",
                Price = 575M,
                Description = "Slow Initial Rendering: Since the data is fetched from the server before rendering, initial load times can be slow, resulting in a less-than-ideal user experience."
            };
            BikeStandartModel secondStandartBike = new BikeStandartModel()
            {
                Id = 2,
                ModelName = "Bike 2",
                ImageUrl = "https://test/bikes/bike-2.webp",
                Price = 365M,
                Description = "Loading States: Users may experience an in-between or loading state, as they wait for the data to be rendered on the page."
            };

            int incorrectId = 3;

            _fakeDbContext.Setup(x => x.BikesStandartModels).ReturnsDbSet(new List<BikeStandartModel> { firstStandartBike, secondStandartBike });

            //Act
            var actual = await _bikeService.GetBikeModelAsync(incorrectId);

            //Assert
            Assert.IsNull(actual);
        }
    }
}
