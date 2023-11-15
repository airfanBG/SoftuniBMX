namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Models.IdentityModels;

    public interface IModelsFactory
    {
        Client CreateNewClientModel(ClientRegisterDto clientRegisterDto);

        Town CreateNewTown(string townName);
    }
}
