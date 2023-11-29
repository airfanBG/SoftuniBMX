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
        public async Task<IActionResult> UserCreateOrder([FromBody]UserOrderDto userOrder)
        {
            var createdOrder = await _userService.CreateOrderByUserAsync(userOrder);

            if (createdOrder!=null)
            {
                 var result = await _userService.CreateOrderPartEmployeeByUserOrder(createdOrder);
            }

            return Ok();
        }

        //[HttpPost("progress")]
        //public async Task<ICollection<OrderProgretionDto>> GetOrderProgress(string userId)
        //{
        //    var collection = await _userService.GetOrdersProgresions(userId);

        //    return collection;
        //}
    }
}
