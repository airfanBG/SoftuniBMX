namespace BicycleApp.Services.Models.Email
{
    public class EmailSendInfoDto
    {
        public EmailReceiverDto Receiver { get; set; } = null!;
        public EmailContentDto Content { get; set; } = null!;       
    }
}
