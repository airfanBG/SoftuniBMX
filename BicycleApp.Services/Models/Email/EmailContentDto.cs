namespace BicycleApp.Services.Models.Email
{
    public class EmailContentDto : IEmailContentDto
    {
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
        public byte[]? FileAttachment { get; set; }
    }
}