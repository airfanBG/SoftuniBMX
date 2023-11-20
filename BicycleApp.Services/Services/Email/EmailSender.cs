namespace BicycleApp.Services.Services.Email
{
    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Email;

    using MailKit.Net.Smtp;

    using Microsoft.Extensions.Configuration;

    using MimeKit;

    using System;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.Encodings.Web;

    public class EmailSender : IEmailSender
    {
        private readonly BicycleAppDbContext _db;
        private readonly IConfiguration _config;
        private readonly IUserFactory _factory;
        public EmailSender(BicycleAppDbContext db, IConfiguration config, IUserFactory factory)
        {
            _db = db;
            _config = config;
            _factory = factory;
        }

        /// <summary>
        /// Reset user`s password and send email notification.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns>bool</returns>
        public async Task<bool> ResetUserPasswordWhenForrgotenAsync(string userId, string role)
        {
            try
            {
                BaseUser? user = await _factory.GetUserAsync(userId, role);
                if (user != null)
                {
                    //Get password form secrets.json
                    var defaultPassword = _config.GetSection("ClientDefautPassword").Value;
                    //The password can be random generated.
                    //var defaultPassword = RandomStringGenerator();

                    //This can be differen base on login encryption.
                    var sha = SHA256.Create();
                    var asByteArray = Encoding.Default.GetBytes(defaultPassword);
                    var hashedPassword = sha.ComputeHash(asByteArray);

                    user.PasswordHash = Convert.ToBase64String(hashedPassword);

                    var email = new EmailSendInfoDto()
                    {
                        Receiver = new EmailReceiverDto()
                        {
                            EmailAddress = user.Email
                        },
                        Content = new EmailContentDto()
                        {
                            Subject = "Reset password",
                            Body = $"Your password was reset. The default is: {defaultPassword} \n Please, change it!"
                        }
                    };

                    var result = IsSuccessfulSendEmail(email);

                    if (result)
                    {
                        await _db.SaveChangesAsync();
                        return true;
                    }
                }

            }
            catch (Exception) { }
            return false;
        }

        /// <summary>
        /// Send email when user is register with unique code for verification.
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="userName"></param>
        /// <param name="callbackUrl"></param>
        /// <returns>bool</returns>
        public bool IsSendedEmailForVerification(string userEmail, string userName, string callbackUrl)
        {
            try
            {
                string callabck = $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.";

                var email = new EmailSendInfoDto()
                {
                    Receiver = new EmailReceiverDto()
                    {
                        EmailAddress = userEmail,
                        Name = userName
                    },
                    Content = new EmailContentDto()
                    {
                        Subject = "Confirmation of email",
                        Body = callabck
                    }
                };

                var result = IsSuccessfulSendEmail(email);
                if (result)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            return false;
        }

        /// <summary>
        /// Verify user`s email.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>bool</returns>
        public async Task<bool> IsUserVerifiedEmailAsync(UserConfirmEmailDto user)
        {
            try
            {
                BaseUser? userToVerify = await _factory.GetUserAsync(user.Id, user.Role);

                string? code = _db.UserTokens.First(u => u.UserId == user.Id).Value;

                if (code != null && userToVerify != null)
                {
                    if (code == user.Code)
                    {
                        userToVerify.EmailConfirmed = true;

                        await _db.SaveChangesAsync();

                        return true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return false;
        }

        /// <summary>
        /// Email sender.
        /// </summary>
        /// <param name="emailInfo"></param>
        /// <returns>bool</returns>
        public bool IsSuccessfulSendEmail(EmailSendInfoDto emailInfo)
        {
            try
            {
                //Values are stored in secrets.json
                var emailSection = _config.GetSection("Email");
                var sender = emailSection.GetSection("Sender").Value;
                var password = emailSection.GetSection("Password").Value;

                var email = new MimeMessage();

                email.From.Add(new MailboxAddress("eXtreme BMX", sender));
                email.To.Add(new MailboxAddress(emailInfo.Receiver.Name, emailInfo.Receiver.EmailAddress));

                email.Subject = emailInfo.Content.Subject;
                email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
                {
                    Text = emailInfo.Content.Body
                };
                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("smtp.abv.bg", 465, true);

                    smtp.Authenticate(sender, password);

                    smtp.Send(email);
                    smtp.Disconnect(true);
                }

                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        //private string RandomStringGenerator()
        //{
        //    int length = 10; 
        //    string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#"; 

        //    Random random = new Random();
        //    StringBuilder sb = new StringBuilder();

        //    for (int i = 0; i < length; i++)
        //    {
        //        int randomChar = random.Next(0, allowedChars.Length+1);
        //        sb.Append(allowedChars[randomChar]);
        //    }

        //    return sb.ToString();
        //}
    }
}
