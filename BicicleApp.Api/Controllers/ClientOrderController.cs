namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.Models.Order.OrderUser;
    using Microsoft.AspNetCore.Mvc;
    using static Org.BouncyCastle.Math.EC.ECCurve;

    [Route("api/client_order")]
    [ApiController]
    public class ClientOrderController : ControllerBase
    {
        private readonly IOrderUserService _userService;
        private readonly IConfiguration _config;
        public ClientOrderController(IOrderUserService userService, IConfiguration config)
        {
            _userService = userService;
            _config = config;
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
                    var advancePaymentPercentage = decimal.Parse(_config.GetSection("AdvancePaymentPercentage").Value);

                    var isReducedAmoutForOrder = await _userService.DeductionByAmount(userOrder.ClientId, advancePaymentPercentage, createdOrder);

                    if (isReducedAmoutForOrder)
                    {
                        var successOrder = (SuccessOrderInfo)_userService.SuccessCreatedOrder(createdOrder);

                        return Ok(successOrder);
                    }
                }
            }
            return BadRequest();
        }

        [HttpPost("progress")]
        public async Task<ActionResult<ICollection<OrderProgretionDto>>> GetOrderProgress([FromQuery]string id)
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

    }
}
