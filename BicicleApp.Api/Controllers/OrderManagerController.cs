using BicycleApp.Services.Contracts;
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
        public async Task<IActionResult> PendingOrders()
        {

            try
            {
                var model = await _orderManagerService.AllPendingOrdersAsync();

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
        public async Task<IActionResult> DeleteOrder([FromQuery] int orderId)
        {
            if (orderId <= 0)
            {
                return StatusCode(400);
            }

            try
            {
                await _orderManagerService.ManagerDeleteOrder(orderId);

                return Ok();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("approve_order")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ApproveOrder([FromQuery] int orderId)
        {
            if (orderId <= 0)
            {
                return StatusCode(400);
            }

            try
            {
                var result = await _orderManagerService.AcceptAndAssignOrderByManagerAsync(orderId);

                if (result == false)
                {
                    return StatusCode(400);
                }

                return StatusCode(200);

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

                return StatusCode(200);
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

        [HttpPost]
        [Route("finished_orders")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> FinishedOrdersForPeriod([FromBody] FinishedOrdersDto datesPeriod)
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
                    return StatusCode(StatusCodes.Status202Accepted);
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
    }  
}
