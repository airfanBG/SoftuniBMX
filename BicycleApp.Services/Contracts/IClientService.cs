namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.IdentityModels;

    public interface IClientService
    {
        Task<bool> RegisterClientAsync(ClientRegisterDto clientDto, string httpScheme, string httpHost);

        Task<ClientReturnDto> LoginClientAsync(ClientLoginDto clientDto);

        Task<ClientInfoDto?> GetClientInfoAsync(string Id);

        Task<bool> ChangeClientPasswordAsync(ClientPasswordChangeDto clientPasswordChangeDto);
        Task ConfirmEmailAsync(string clientId, string code);

        Task<ClientBankDto> GetClientBankInfoAsync(string clientId);

        Task<bool> UpdateClientBankInfoAsync(ClientBankDto clientBankDto);

        Task<bool> ChangePassword(ClientLoginDto clientLoginDto);

        Task<bool> ResetPasswordToDefault(string email);

        Task<bool> EditClientInfoAsync(ClientEditDto clientEditDto);
    }
}
