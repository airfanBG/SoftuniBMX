namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
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
        public async Task<IActionResult> GetEmployeeWorkingMinutesForPastAndCurrentMonth([FromQuery] string employeeId)
        {
            var responceObj = await _managerSatisticsService.GetEmployeeOutputForThePastAndCurrentMonth(employeeId);

            if (responceObj != null)
            {
                return Ok(responceObj);
            }

            return BadRequest();
        }
    }
}
