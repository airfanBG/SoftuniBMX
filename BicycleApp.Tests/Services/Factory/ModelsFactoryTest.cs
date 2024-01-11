namespace BicycleApp.Tests.Services.Factory
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Services.Factory;

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
                Price = price
            };

            //Act

            var actual = _modelFactory.CreateNewBikeStandartModel(bike);

            //Assert
        }

    }
}
