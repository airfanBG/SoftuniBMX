namespace BicycleApp.Services.Contracts
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string receiver, string subject, string content);
    }
}
