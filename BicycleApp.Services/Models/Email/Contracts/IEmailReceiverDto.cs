namespace BicycleApp.Services.Models.Email.Contracts
{
    public interface IEmailReceiverDto
    {
        public string? Name { get; set; }
        public string EmailAddress { get; set; }
    }
}
