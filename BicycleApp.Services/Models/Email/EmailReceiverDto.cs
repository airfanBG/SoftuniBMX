using BicycleApp.Services.Models.Email.Contracts;

namespace BicycleApp.Services.Models.Email
{
    public class EmailReceiverDto : IEmailReceiverDto
    {
        public string? Name { get; set; }
        public string EmailAddress { get; set; } = null!;
    }
}