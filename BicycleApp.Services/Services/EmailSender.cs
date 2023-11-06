namespace BicycleApp.Services.Services
{
    
    using BicycleApp.Services.Contracts;
    using Microsoft.Extensions.Configuration;
    using System.Net;
    using System.Net.Mail;
    using System.Threading.Tasks;

    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _config;
        public EmailSender(IConfiguration config)
        {
            this._config = config;
        }

        public async Task SendEmailAsync(string receiver, string subject, string content)
        {
            //Values are stored in secrets.json
            var email = _config.GetSection("Email");
            var sender = email.GetSection("Sender").Value;
            var password = email.GetSection("Password").Value;

            var client = new SmtpClient("smtp.abv.bg", 465)
            {                
                EnableSsl = true,
                Credentials = new NetworkCredential(sender, password)
            };
           
            await client.SendMailAsync(new MailMessage(from: sender,
                                                to: receiver,
                                                subject: subject,
                                                body: content
                                                ));
        }
    }
}
