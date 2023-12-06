using BicycleApp.Services.Contracts;
using BicycleApp.Services.Models.Supply;
using BicycleApp.Services.Services.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BicicleApp.Api.Controllers
{
    [Route("api/supplys_manager")]
    [ApiController]
    public class SupplyManagerController : ControllerBase
    {
        private readonly ISupplyManagerService _supplyManagerService;

        public SupplyManagerController(ISupplyManagerService                    supplyManagerService)
        {
            _supplyManagerService = supplyManagerService;
        }

        [HttpGet]
        [Route("deliveries")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Deliveries([FromQuery] AllDeliveriesQueryModel deliveriesQuery)
        {

            try
            {

                var result = await _supplyManagerService.AllDeliveries(
                                        deliveriesQuery.Supplier,
                                        deliveriesQuery.SearchTerm,
                                        deliveriesQuery.Sorting,
                                        deliveriesQuery.CurrentPage,
                                       AllDeliveriesQueryModel.DeliveriesPerPage
                                        );

                deliveriesQuery.TotalDeliveriesCount = result.TotalDeliveriesCount; 
                deliveriesQuery.Deliveries = result.Deliveries;

                if (result == null)
                {
                    // The model object is null, so return a 204 NoContent
                    return StatusCode(204);
                }

                return StatusCode(200, result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

    }
}
