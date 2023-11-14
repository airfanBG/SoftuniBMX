namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.IdentityModels;

    public interface IClientService
    {
        Task<bool> RegisterClientAsync(ClientRegisterDto clientDto);

        Task<ClientReturnDto> LoginClientAsync(ClientLoginDto clientDto);

        Task<ClientInfoDto?> GetClientInfoAsync(string Id);
    }
}
