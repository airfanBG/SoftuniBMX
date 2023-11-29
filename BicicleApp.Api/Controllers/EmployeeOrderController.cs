namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Order;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/employeeOrder")]
    [ApiController]
    public class EmployeeOrderController : ControllerBase
    {
        private readonly IEmployeeOrderService employeeOrderService;

        public EmployeeOrderController(IEmployeeOrderService employeeOrderService)
        {
            this.employeeOrderService = employeeOrderService;
        }

        [HttpGet]
        [Route("myOrders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<EmployeePartOrdersDto>> MyOrders([FromQuery] string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            try
            {
                var model = await employeeOrderService.GetAllOrdersAsignedToEmployee(id);
                return Ok(model);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("start")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> StartOrder(PartOrdersStartEndDto partOrdersStartEndDto)
        {
            if (partOrdersStartEndDto == null)
            {
                return StatusCode(422);
            }

            try
            {
                var result = await employeeOrderService.StartOrderByEmployee(partOrdersStartEndDto);

                if (result)
                {
                    return NoContent();
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("end")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> EndOrder(PartOrdersStartEndDto partOrdersStartEndDto)
        {
            if (partOrdersStartEndDto == null)
            {
                return StatusCode(422);
            }

            try
            {
                var result = await employeeOrderService.EndOrderByEmployee(partOrdersStartEndDto);

                if (result)
                {
                    return NoContent();
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
