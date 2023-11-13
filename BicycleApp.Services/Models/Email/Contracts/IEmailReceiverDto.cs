namespace BicycleApp.Services.Models.Email
{
    public interface IEmailReceiverDto
    {
        public string? Name { get; set; }
        public string EmailAddress { get; set; }
    }
}
