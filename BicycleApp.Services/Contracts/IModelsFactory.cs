namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Data.Models.EntityModels;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Models;
    using BicycleApp.Services.Models.IdentityModels;
    using BicycleApp.Services.Models.IdentityModels.Contracts;
    using BicycleApp.Services.Models.Supply;

    public interface IModelsFactory
    {
        Client CreateNewClientModel(IBaseClientDto clientRegisterDto);

        Employee CreateNewEmployee(EmployeeRegisterDto employeeRegisterDto);

        Town CreateNewTown(string townName);

        Department CreateNewDepartment(string departmentName);

        BikeStandartModel CreateNewBikeStandartModel(BikeStandartTypeAddDto bikeStandartTypeAddDto);

        Comment CreateNewComment(CommentAddDto commentAddDto);

        Part CreatePart(PartAddDto partAddDto);

        Delivary CreateNewDelivery(CreateDelivedryDto createDelivedryDto);

        Suplier CreateNewSuplier(CreateSuplierDto createSuplierDto);

        PartOrder CreateNewPartOrder(CreatePartOrderDto createPartOrderDto);

        DelivaryAddress CreateNewDelivaryAddress(IDelivaryAddressDto clientDelivaryAddressDto);
    }
}
