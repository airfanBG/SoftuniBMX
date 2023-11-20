namespace BicycleApp.Services.Contracts
{
    using BicycleApp.Services.Models.Email;

    public interface IEmailSender
    {
        Task<bool> ResetUserPasswordWhenForrgotenAsync(string clientId, string role);
        bool IsSendedEmailForVerification(string code, string userEmail, string callbackUrl);
        Task<bool> IsUserVerifiedEmailAsync(UserConfirmEmailDto user);
        bool IsSuccessfulSendEmail(EmailSendInfoDto emailInfo);
    }
}
