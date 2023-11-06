namespace BicycleApp.Web.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class EmailSender : ControllerBase
    {
        private readonly IEmailSender _emailSender;
        private readonly IImageStore _imageStore;

        public EmailSender(IEmailSender emailSender, IImageStore imageStore)
        {
            _emailSender = emailSender;
            _imageStore = imageStore;
        }

        [HttpPost]
        public IActionResult SendEmail([FromBody] EmailSendDto emailSend)
        {
            _emailSender.SendEmailAsync(emailSend.Recivier, emailSend.Subject, emailSend.Body);

            return Ok();
        }

        [HttpPost("saveImage")]
        public async Task<IActionResult> SaveImage([FromForm] UserImageDto userImageDto)
        {
           bool result = await _imageStore.IsAddedOrReplacedUserImage(userImageDto);

            return Ok();
        }

        [HttpGet("getUsersImage")]
        public async Task<IActionResult> GetImage()
        {
            string userId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd";
            string userRole = "client";
            var img = _imageStore.GetUserImage(userId, userRole);

            return Ok();
        }

    }
}
