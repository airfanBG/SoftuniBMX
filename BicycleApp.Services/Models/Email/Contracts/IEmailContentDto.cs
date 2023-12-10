namespace BicycleApp.Services.Models.Email.Contracts
{
    public interface IEmailContentDto
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public byte[]? FileAttachment { get; set; }
    }
}
