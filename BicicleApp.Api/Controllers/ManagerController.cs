using BicycleApp.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BicicleApp.Api.Controllers
{
    [Route("api/manager")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IOrderManagerService _orderManagerService;

        public ManagerController(IOrderManagerService orderManagerService)
        {
            _orderManagerService = orderManagerService;
        }

        //HttpGet - GetAllPendingOrders

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

                return Ok(model);
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
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteOrder([FromQuery] int orderId)
        {

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


        //HttpPost(with Json Attribute) - AcceptAndAssignOrder(ManagerApprovalDto managerApprovalDto)- Тошко ще преправи Dto-то и няма да ми трябва EmployeeId-то!

        //Do I have service that returns Employee by Role -    !!?
        //I have: public async Task<EmployeeInfoDto?> GetEmployeeInfoAsync(string Id) 

        //HttpGet - ArePartsAvailable(int partsInOrder, int partInStockId);


        //HttpPost(with Json Attribute) - ManagerOrderRejection(int orderId);
    }
        
}
