namespace BicycleApp.Services.Services.Email
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Email;

    using MailKit.Net.Smtp;
    using MimeKit;

    using System;
    using System.Security.Cryptography;
    using System.Security.Policy;
    using System.Text;
    using System.Text.Encodings.Web;
    using static BicycleApp.Common.EntityValidationConstants;
    using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

    public class EmailSender : IEmailSender
    {
        private readonly BicycleAppDbContext _db;
        private readonly IUserFactory _factory;
        private readonly IOptionProvider _optionProvider;
        public EmailSender(BicycleAppDbContext db,IUserFactory factory, IOptionProvider optionProvider)
        {
            _db = db;
            _factory = factory;
            _optionProvider = optionProvider;
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
                    var defaultPassword = _optionProvider.ClientDefautPassword();
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
        /// <param name="confirmationToken"></param>
        /// <returns>bool</returns>
        public bool IsSendedEmailForVerification(string userEmail, string userName, string callbackUrl)
        {
            try
            {
                var callbackBody = $"Please confirm your account by clicking -> {callbackUrl}";
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
                        Body = callbackBody
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
                var sender = _optionProvider.EmailAccoutUsername();
                var password = _optionProvider.EmailAccoutPassword();

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
