namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.Models.Order.OrderUser;
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

        [HttpPost("create")]
        public async Task<ActionResult<SuccessOrderInfo>> UserCreateOrder([FromBody]UserOrderDto userOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var createdOrder = await _userService.CreateOrderByUserAsync(userOrder);

            if (createdOrder != null)
            {
                var result = await _userService.CreateOrderPartEmployeeByUserOrder(createdOrder);

                if (result)
                {
                    var successOrder = (SuccessOrderInfo)_userService.SuccessCreatedOrder(createdOrder);

                    return Ok(successOrder);
                }
            }
            return BadRequest();
        }

        [HttpPost("progress")]
        public async Task<ActionResult<ICollection<OrderProgretionDto>>> GetOrderProgress(string userId)
        {           
            var userOrdersProgression = await _userService.GetOrdersProgresions(userId);

            if (userOrdersProgression != null)
            {
                return Ok(userOrdersProgression);
            }

            return BadRequest();
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteOrder([FromQuery] string userId, [FromQuery] int orderId)
        {
            await _userService.DeleteOrder(userId, orderId);

            return Ok();
        }
    }
}
