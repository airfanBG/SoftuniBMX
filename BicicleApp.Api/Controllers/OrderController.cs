namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Order;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("CreateOrder")]
        public async Task<IActionResult> MakeOrder([FromBody]OrderDto orderDto)
        {
            var result = await _orderService.CreateOrderByUserAsync(orderDto);
            return Ok();
        }

        [HttpPost("AssignOrder")]
        public async Task<IActionResult> AssignOrder([FromBody] ManagerApprovalDto managerApprovalDto)
        {
            var result = await _orderService.AcceptAndAssignOrderByManagerAsync(managerApprovalDto);

            return Ok();
        }

        [HttpGet("GetOrders")]
        public async Task<ICollection<OrderInfoDto>> GetOrders()
        {
            var result = await _orderService.AllPendingOrdersAsync();

            return result;
        }
        [HttpPost("EmployeeUnfinishedTasks")]
        public async Task<ICollection<EmployeePartTaskDto>> EmployeeUnfinishedTasks(string employeeId)
        {
            var result = await _orderService.EmployeeUnfinishedTask(employeeId);

            return result;
        }
    }
}
