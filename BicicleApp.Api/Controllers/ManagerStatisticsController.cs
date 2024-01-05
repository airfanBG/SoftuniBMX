namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Order.OrderManager;
    using BicycleApp.Services.Services.Order;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/manager_statistics")]
    [ApiController]
    public class ManagerStatisticsController : ControllerBase
    {
        private readonly IManagerSatisticsService _managerSatisticsService;

        public ManagerStatisticsController(IManagerSatisticsService managerSatisticsService)
        {
            _managerSatisticsService = managerSatisticsService;
        }

        [HttpGet]
        [Route("employee_statistics")]
        public async Task<IActionResult> GetEmployeeWorkingMinutesForPastAndCurrentMonth([FromQuery] string employeeId)
        {
            var responceObj = await _managerSatisticsService.GetEmployeeOutputForThePastAndCurrentMonth(employeeId);

            if (responceObj != null)
            {
                return Ok(responceObj);
            }

            return BadRequest();
        }

        [HttpGet]
        [Route("order_statistics")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> OrderStatistics([FromQuery] FinishedOrdersDto datesPeriod)
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
                var result = await _managerSatisticsService.GetOrderStatistics(datesPeriod);


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

        [HttpGet]
        [Route("part_statistics")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> PartStatistics([FromQuery] FinishedOrdersDto datesPeriod)
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
                var result = await _managerSatisticsService.GetPartStatistics(datesPeriod);


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
    }
}
