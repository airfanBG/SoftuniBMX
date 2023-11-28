namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.Models.Order;
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
                              

        [HttpPost("progress")]
        public async Task<ICollection<OrderProgretionDto>> GetOrderProgress(string userId)
        {
            var collection = await _userService.GetOrdersProgresions(userId);

            return collection;
        }

    }
}
