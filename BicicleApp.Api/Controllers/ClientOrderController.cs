namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.Models.Order.OrderUser;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/client_order")]
    [ApiController]
    public class ClientOrderController : ControllerBase
    {
        private readonly IOrderUserService _userService;
        public ClientOrderController(IOrderUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("create")]
        public async Task<ActionResult<SuccessOrderInfo>> UserCreateOrder([FromBody] UserOrderDto userOrder)
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
        public async Task<ActionResult<ICollection<OrderProgretionDto>>> GetOrderProgress([FromQuery] string id)
        {
            var userOrdersProgression = await _userService.GetOrdersProgresions(id);

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

        [HttpGet]
        [Route("get_orders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<OrderClientShortInfo>>> GetAllMyOrdersShortInfoByStatus([FromQuery] string clientId)
        {
            if (clientId == null)
            {
                return BadRequest(clientId);
            }
            try
            {
                var orders = await _userService.GetAllOrdersForClientByStatus(clientId, 1);

                return Ok(orders);
            }
            catch (Exception)
            {
                return StatusCode(500, clientId);
            }
        }
    }
}
