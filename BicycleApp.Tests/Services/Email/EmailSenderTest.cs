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
    using NUnit.Framework.Constraints;

    public class EmailSenderTest
    {
        private static readonly Mock<BicycleAppDbContext> fakeContext = new Mock<BicycleAppDbContext>();
        private static readonly Mock<IUserFactory> fakeUserFactory = new Mock<IUserFactory>();
        private static readonly Mock<IOptionProvider> fakeOptionProvider = new Mock<IOptionProvider>();

        private readonly IEmailSender emailSender = new EmailSender(fakeContext.Object, fakeUserFactory.Object, fakeOptionProvider.Object);


        [Test]
        public void IsSuccessfulSendEmail_Should_ReturnTrue_WhenEmailIsSeccessfulSend()
        {
            // Arrange

            // Act
            var result = emailSender.IsSuccessfulSendEmail(It.IsAny<EmailSendInfoDto>());

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
