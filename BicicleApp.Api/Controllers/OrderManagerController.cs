using BicycleApp.Data.Models.IdentityModels;
using BicycleApp.Services.Contracts;
using BicycleApp.Services.Models.IdentityModels;
using BicycleApp.Services.Models.Order;
using BicycleApp.Services.Models.Order.OrderManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BicicleApp.Api.Controllers
{
    [Route("api/manager")]
    [ApiController]
    public class OrderManagerController : ControllerBase
    {
        private readonly IOrderManagerService _orderManagerService;

        public OrderManagerController(IOrderManagerService orderManagerService)
        {
            _orderManagerService = orderManagerService;
        }

        [HttpGet]
        [Route("pending_orders")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PendingOrders([FromQuery] int page = 1)
        {

            if (page <= 0)
            {
                return StatusCode(400);
            }

            try
            {
                var model = await _orderManagerService.AllPendingOrdersAsync(page);

                if (model == null)
                {
                    // The model object is null, so return a 204 NoContent
                    return StatusCode(204);
                }

                return StatusCode(200, model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("orders_in_progress")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> OrdersInProgress()
        {

            try
            {
                var model = await _orderManagerService.AllOrdersInProgressAsync();

                if (model == null)
                {
                    // The model object is null, so return a 204 NoContent
                    return StatusCode(204);
                }

                return StatusCode(200, model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("rejected_orders")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RejectedOrders()
        {

            try
            {
                var model = await _orderManagerService.AllRejectedOrdersAsync();

                if (model == null)
                {
                    // The model object is null, so return a 204 NoContent
                    return StatusCode(204);
                }

                return StatusCode(200, model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("delete_order")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> DeleteOrder([FromQuery] int orderId)
        {
            if (orderId <= 0)
            {
                return StatusCode(400);
            }

            try
            {
                var deletedOrderId = await _orderManagerService.ManagerDeleteOrder(orderId);

                if (deletedOrderId > 0)
                {
                    return StatusCode(200, deletedOrderId);
                }               
            }
            catch (Exception)
            {
            }

            int invalidOrderId = 0;
            return StatusCode(500, invalidOrderId);
        }

        [HttpPost]
        [Route("approve_order")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> ApproveOrder([FromQuery] int orderId)
        {
            if (orderId <= 0)
            {
                return StatusCode(400);
            }

            try
            {
                var result = await _orderManagerService.AcceptAndAssignOrderByManagerAsync(orderId);

                if (result == 0)
                {
                    return StatusCode(400);
                }

                return StatusCode(200, result);

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("approve_rejected_order")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ApproveRejectedOrder([FromQuery] int orderId)
        {
            if (orderId <= 0)
            {
                return StatusCode(400);
            }

            try
            {

                var result = await _orderManagerService.AcceptAndAssignRejectedOrderByManagerAsync(orderId);

                if(result == false)
                {
                    return StatusCode(400);
                }

                return StatusCode(200, result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("reject_order")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RejectOrder([FromQuery] int orderId)
        {
            if (orderId <= 0)
            {
                return StatusCode(400);
            }

            try
            {
                var model = await _orderManagerService.RejectOrderAsync(orderId);

                if (model == null)
                {
                    // The model object is null, so return a 204 NoContent
                    return StatusCode(204);
                }

                return StatusCode(200, model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("finished_orders")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> FinishedOrdersForPeriod([FromQuery] FinishedOrdersDto datesPeriod)
        {
            if (datesPeriod == null)
            {
                return StatusCode(400);
            }

            if (!ModelState.IsValid)
            {
                return StatusCode(422, datesPeriod);
            }

            try
            {
                var result = await _orderManagerService.GetAllFinishedOrdersForPeriod(datesPeriod);


                if (result != null)
                {
                    return StatusCode(StatusCodes.Status202Accepted, result);
                }
                else
                {
                    return StatusCode(422, datesPeriod);
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("all_employees")]
        public async Task<ActionResult<ICollection<EmployeeInfoDto>>> GetAllEmployees()
        {
            var allEmployeeCollection = await _orderManagerService.GetAllEmployees();

            return StatusCode(200, allEmployeeCollection);
        }

        [HttpGet]
        [Route("deleted_orders")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletedOrders([FromQuery] int page = 1)
        {

            if (page <= 0)
            {
                return StatusCode(400);
            }

            try
            {
                var model = await _orderManagerService.AllDeletedOrdersAsync(page);

                if (model == null)
                {
                    // The model object is null, so return a 204 NoContent
                    return StatusCode(204);
                }

                return StatusCode(200, model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
