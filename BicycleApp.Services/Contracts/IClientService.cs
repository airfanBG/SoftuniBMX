namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.IdentityModels;

    public interface IClientService
    {
        Task<bool> RegisterClientAsync(ClientRegisterDto clientDto, string httpScheme, string httpHost);

        Task<ClientReturnDto> LoginClientAsync(ClientLoginDto clientDto);

        Task<ClientInfoDto?> GetClientInfoAsync(string Id);

        Task<bool> ChangeClientPasswordAsync(ClientPasswordChangeDto clientPasswordChangeDto);
        Task ConfirmEmail(string clientId, string code);
    }
}
