namespace BicycleApp.Tests.Services.Factory
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Bike;
    using BicycleApp.Services.Services.Factory;
    using Newtonsoft.Json;

    public class ModelsFactoryTest
    {
        private readonly IModelsFactory _modelFactory;

        public ModelsFactoryTest()
        {
            _modelFactory = new ModelsFactory();
        }

        [Test]
        public void CreateNewBikeStandartModel_ShouldCreateBikeStandartModel()
        {
            //Arrange
            string description = "Test description";
            string imageUrl = "https://testbike/test/image.jpg";
            string modelName = "Test model name";
            decimal price = 152.26M;

            BikeStandartTypeAddDto bike = new BikeStandartTypeAddDto
            {
                Description = description,
                ImageUrl = imageUrl,
                ModelName = modelName,
                Price = price,
            };

            //Act
            var actual = _modelFactory.CreateNewBikeStandartModel(bike);

            //Assert
            Assert.AreEqual(bike.Description, actual.Description);
            Assert.AreEqual(bike.ImageUrl, actual.ImageUrl);
            Assert.AreEqual(bike.ModelName, actual.ModelName);
            Assert.AreEqual(bike.Price, actual.Price);
        }

    }
}
