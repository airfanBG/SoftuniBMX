namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.IdentityModels;

    public interface IClientService
    {
        Task<bool> RegisterClient(ClientRegisterDto clientDto);

        Task<bool> LoginClient(ClientLoginDto clientDto);
    }
}
