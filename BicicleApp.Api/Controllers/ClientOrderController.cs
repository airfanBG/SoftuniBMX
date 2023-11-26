namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.Models.Order;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ClientOrderController : ControllerBase
    {
        private readonly IOrderUserService _userService;
        private readonly IEmailSender _emailSender;
        public ClientOrderController(IOrderUserService userService, IEmailSender emailSender)
        {
            _userService = userService;
            _emailSender = emailSender;
        }

        [HttpPost("GetOrdersStatus")]
        public async Task<ICollection<OrderProgretionDto>> GetOrdersStatus(string clientId)
        {
            var result = await _userService.GetOrdersProgresions(clientId);

            return result;
        }

        [HttpGet]
        public async Task<IActionResult> PasswordCheck()
        {

            var result = await _emailSender.ResetUserPasswordWhenForrgotenAsync("17ce735d-6713-4d0a-8fcb-e4a71ee86f6f", "client");

            return Ok();
        }

    }
}
