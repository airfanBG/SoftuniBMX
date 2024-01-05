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
        public async Task<ActionResult<SuccessOrderInfo>> UserCreateOrder([FromBody] UserOrderDto userOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var createdOrder = _userService.CreateOrderByUser(userOrder);

            if (createdOrder != null)
            {
                var result = _userService.CreateOrderPartEmployeeByUserOrder(createdOrder);

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
        [Route("get_orders_ready")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<OrderClientShortInfo>>> GetAllMyOrdersShortInfoByStatusReady([FromQuery] string clientId)
        {
            if (clientId == null)
            {
                return BadRequest(clientId);
            }
            try
            {
                //Use the status id for ready
                var orders = await _userService.GetAllOrdersForClientByStatus(clientId, 6);

                return Ok(orders);
            }
            catch (Exception)
            {
                return StatusCode(500, clientId);
            }
        }

        [HttpGet]
        [Route("get_orders_archive")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<OrderClientShortInfo>>> GetAllMyOrdersShortInfoByStatusSend([FromQuery] string clientId)
        {
            if (clientId == null)
            {
                return BadRequest(clientId);
            }
            try
            {
                //Use the status id for already sended orders
                var orders = await _userService.GetAllOrdersForClientByStatus(clientId, 7);

                return Ok(orders);
            }
            catch (Exception)
            {
                return StatusCode(500, clientId);
            }
        }

        [HttpGet]
        [Route("find")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<OrderDtoInfo>> GetOrderById([FromQuery] int orderId)
        {
            try
            {
                var order = await _userService.GetOrderById(orderId);

                if (order == null)
                {
                    return BadRequest(orderId);
                }

                return Ok(order);
            }
            catch (Exception)
            {
                return StatusCode(500, orderId);
            }
        }
    }
}
