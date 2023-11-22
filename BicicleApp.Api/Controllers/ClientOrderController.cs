namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.Models.Order;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ClientOrderController : ControllerBase
    {
        private readonly IOrderUserService _userService;
        public ClientOrderController(IOrderUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("GetOrdersStatus")]
        public async Task<ICollection<OrderProgretionDto>> GetOrdersStatus(string clientId)
        {
            var result = await _userService.GetOrdersProgresions(clientId);

            return result;
        }
    }
}
