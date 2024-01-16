namespace BicycleApp.Tests.Services.Email
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Data;
    using BicycleApp.Data.Models.IdentityModels;
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.Factory;
    using BicycleApp.Services.Models.Email;
    using BicycleApp.Services.Services.Email;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Moq.EntityFrameworkCore;

    public class EmailSenderTest
    {
        private static readonly Mock<BicycleAppDbContext> _fakeDbContext = new Mock<BicycleAppDbContext>();
        private static readonly Mock<IUserFactory> _fakeUserFactory = new Mock<IUserFactory>();
        private static readonly Mock<IOptionProvider> _fakeOptionProvider = new Mock<IOptionProvider>();

        private readonly IEmailSender emailSender;
        public EmailSenderTest()
        {
            emailSender = new EmailSender(_fakeDbContext.Object, _fakeUserFactory.Object, _fakeOptionProvider.Object);
        }

        //[Test]
        //public async Task ResetUserPasswordWhenForrgotenAsync_Should_ReturnTrue_WhenPasswordIsSuccessfulReset()
        //{
        //    //Arrange
        //    Client client = new Client
        //    {
        //        Id = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
        //        Email = "client@test.bg",
        //        UserName = "client@test.bg",
        //        NormalizedEmail = "client@test.bg".ToUpper(),
        //        SecurityStamp = "client@test.bg".ToUpper(),
        //        FirstName = "Ivan",
        //        LastName = "Ivanov",
        //        PhoneNumber = "1234567890",
        //        DelivaryAddressId = 1,
        //        TownId = 1,
        //        IBAN = "BG0012345678910111212",
        //        Balance = 1000.00M,
        //        IsDeleted = false,
        //        DateCreated = new DateTime(2024, 1, 1),
        //        DateUpdated = null,
        //        DateDeleted = null,
        //        EmailConfirmed = true,
        //    };

        //    _fakeDbContext.Setup(x => x.Clients).ReturnsDbSet(new List<Client> { client });
        //    _fakeUserFactory.Setup(x => x.GetUserAsync(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(client);
        //    _fakeOptionProvider.Setup(x => x.ClientDefautPassword()).Returns("the most secret password");
                       
        //    emailSender.IsSuccessfulSendEmail(It.IsAny<EmailSendInfoDto>());            

        //    int actualCallOfSaveChanges = 0;
        //    _fakeDbContext.Setup(x => x.SaveChangesAsync(It.IsAny<CancellationToken>())).Callback(() => actualCallOfSaveChanges++);

        //    //Act
        //    var actual = await emailSender.ResetUserPasswordWhenForrgotenAsync(It.IsAny<string>(), It.IsAny<string>());

        //    //Assert
        //    int expectedCallOfSaveChanges = 1;
        //    Assert.AreEqual(expectedCallOfSaveChanges, actualCallOfSaveChanges);

        //}
    }
}
