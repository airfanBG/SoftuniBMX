namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Contracts.OrderContracts;
    using BicycleApp.Services.Models.Order;
    using BicycleApp.Services.Models.Order.OrderUser;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/employee_order")]
    [ApiController]
    public class EmployeeOrderController : ControllerBase
    {
        private readonly IEmployeeOrderService employeeOrderService;
        private readonly IQualityAssuranceService qualityAssuranceService;

        public EmployeeOrderController(IEmployeeOrderService employeeOrderService, IQualityAssuranceService qualityAssuranceService)
        {
            this.employeeOrderService = employeeOrderService;
            this.qualityAssuranceService = qualityAssuranceService;
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
                return StatusCode(400);
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
                    return StatusCode(204);
                }

                return StatusCode(400);       
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
                    return StatusCode(204);
                }

                return StatusCode(400);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("quality_assurance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ICollection<OrderProgretionDto>>> GetReadyOrdersForQualityAssurance()
        {
            var qualityAssuranceOrders = await qualityAssuranceService.GetAllReadyOrder();

            if (qualityAssuranceOrders != null)
            {
                return Ok(qualityAssuranceOrders);
            }

            return StatusCode(500);
        }

        [HttpPost]
        [Route("quality_assurance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PassedQualityAssuranceOrder([FromQuery] int orderId)
        {
            var passedOrderId = await qualityAssuranceService.OrderPassQualityAssurance(orderId);

            if (passedOrderId > 0)
            {
                return Ok(passedOrderId);
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("quality_assurance_return")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ICollection<RemanufacturingPartEmployeeInfoDto>>> RemanufacturingPart([FromBody] OrderProgretionDto orderProgretionDto)
        {
            var infoForPart = await qualityAssuranceService.RemanufacturingPart(orderProgretionDto);

            if (infoForPart != null)
            {
                return Ok(infoForPart);
            }

            return StatusCode(500);
        }
    }
}
