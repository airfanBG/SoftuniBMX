namespace BicycleApp.Tests.Services.Email
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Email;
    using BicycleApp.Services.Services.Email;
    using MailKit.Net.Smtp;
    using MimeKit;
    using Moq;

    public class EmailSenderTest
    {
        private static readonly Mock<BicycleAppDbContext> fakeContext = new Mock<BicycleAppDbContext>();
        private static readonly Mock<IUserFactory> fakeUserFactory = new Mock<IUserFactory>();
        private static readonly Mock<IOptionProvider> fakeOptionProvider = new Mock<IOptionProvider>();

        private readonly IEmailSender emailSender = new EmailSender(fakeContext.Object, fakeUserFactory.Object, fakeOptionProvider.Object);

        private readonly string id = Guid.NewGuid().ToString();

        [Test]
        public void IsSuccessfulSendEmail_Should_ReturnTrue_WhenEmailIsSeccessfulSend()
        {
            // Arrange
            var emailInfo = new EmailSendInfoDto
            {
                Receiver = new EmailReceiverDto
                {
                    Name = "John Doe",
                    EmailAddress = "john.doe@example.com"
                },
                Content = new EmailContentDto
                {
                    Subject = "Test Subject",
                    Body = "Test Body"
                }
            };

            fakeOptionProvider.Setup(x => x.EmailAccoutUsername()).Returns("testuser");
            fakeOptionProvider.Setup(x => x.EmailAccoutPassword()).Returns("testpassword");
            var smtpClient = new SmtpClient();
            smtpClient.Connect(It.IsAny<string>(), It.IsAny<int>());

            // Act
            var result = emailSender.IsSuccessfulSendEmail(emailInfo);

            // Assert
            Assert.IsTrue(result);
        }

        //[Test]
        //public void ResetUserPasswordWhenForrgotenAsync_Should_ReturnTrue_WhenPasswordIsSuccessfulReset()
        //{
        //    fakeUserFactory.Setup(x => x.GetUserAsync(It.IsAny<string>(), It.IsAny<string>()))
        //                                .ReturnsAsync(new BaseUser()
        //                                {
        //                                    Id = id,
        //                                    Email = "testmail@testmail.com",
        //                                    EmailConfirmed = true,
        //                                    FirstName = "Test",
        //                                    LastName = "Test",
        //                                    UserName = "testmail@testmail.com"
        //                                });

        //}
    }
}
