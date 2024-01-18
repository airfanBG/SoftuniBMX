using BicycleApp.Services.Contracts;
using BicycleApp.Services.Models.Supply;
using BicycleApp.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BicicleApp.Api.Controllers
{
    [Route("api/supplys_manager")]
    [ApiController]
    public class SupplyManagerController : ControllerBase
    {
        private readonly ISupplyManagerService _supplyManagerService;

        public SupplyManagerController(ISupplyManagerService supplyManagerService)
        {
            _supplyManagerService = supplyManagerService;
        }

        [HttpGet]
        [Route("deliveries")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Deliveries([FromQuery] int page = 1)
        {

            if (page <= 0)
            {
                return StatusCode(400);
            }

            try
            {

                var result = await _supplyManagerService.AllDeliveries(page);


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

        [HttpGet]
        [Route("supliers")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Supliers()
        {

            try
            {

                var result = await _supplyManagerService.AllSupliers();


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

        [HttpGet]
        [Route("part_orders")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PartOrders()
        {

            try
            {

                var result = await _supplyManagerService.AllPartOrders();


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

        [HttpPost]
        [Route("create_delivery")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateDelivedry([FromBody] CreateDelivedryDto createDeliveryDto)
        {
            if (createDeliveryDto == null)
            {
                return StatusCode(400, createDeliveryDto);
            }

            if (!ModelState.IsValid)
            {
                return StatusCode(400, createDeliveryDto);
            }

            try
            {
                var result = await _supplyManagerService.CreateDelivedry(createDeliveryDto);

                if (result)
                {
                    return StatusCode(201, true);
                }

                return StatusCode(400, createDeliveryDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("create_suplier")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateSuplier([FromBody] CreateSuplierDto createSuplierDto)
        {
            if (createSuplierDto == null)
            {
                return StatusCode(400, createSuplierDto);
            }

            if (!ModelState.IsValid)
            {
                return StatusCode(400, createSuplierDto);
            }

            try
            {
                var result = await _supplyManagerService.CreateSuplier(createSuplierDto);

                if (result)
                {
                    return StatusCode(201, true);
                }

                return StatusCode(400, createSuplierDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("create_part_order")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreatePartOrder([FromBody] CreatePartOrderDto createPartOrderDto)
        {
            if (createPartOrderDto == null)
            {
                return StatusCode(400, createPartOrderDto);
            }

            if (!ModelState.IsValid)
            {
                return StatusCode(400, createPartOrderDto);
            }

            try
            {
                var result = await _supplyManagerService.CreatePartOrder(createPartOrderDto);

                if (result)
                {
                    return StatusCode(201, true);
                }

                return StatusCode(400, createPartOrderDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("get_suplier")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSuplier([FromQuery] int suplierId)
        {

            if (suplierId <= 0)
            {
                return StatusCode(400);
            }

            if (await _supplyManagerService.SuplierExists(suplierId) == false)
            {
                return StatusCode(400);
            }

            try
            {
                var model = await _supplyManagerService.SuplierDetailsById(suplierId);

                return StatusCode(200, model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("get_suplier_parts")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSuplierParts([FromQuery] int suplierId)
        {

            if (suplierId <= 0)
            {
                return StatusCode(400);
            }

            if (await _supplyManagerService.SuplierExists(suplierId) == false)
            {
                return StatusCode(400);
            }

            try
            {
                var model = await _supplyManagerService.GetAllSuplierPartsInStock(suplierId);

                return StatusCode(200, model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("get_delivery")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDelivery([FromQuery] int deliveryId)
        {

            if (deliveryId <= 0)
            {
                return StatusCode(400);
            }

            if (await _supplyManagerService.DeliveryExists(deliveryId) == false)
            {
                return StatusCode(400);
            }

            try
            {
                var model = await _supplyManagerService.DeliveryDetailsById(deliveryId);

                return StatusCode(200, model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("get_part_order")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPartOrder([FromQuery] int partOrderId)
        {

            if (partOrderId <= 0)
            {
                return StatusCode(400);
            }

            if (await _supplyManagerService.PartOrderExists(partOrderId) == false)
            {
                return StatusCode(400);
            }

            try
            {
                var model = await _supplyManagerService.PartOrderDetailsById(partOrderId);

                return StatusCode(200, model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("delete_suplier")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteSuplier([FromQuery] int suplierId)
        {
            if (suplierId <= 0)
            {
                return StatusCode(400);
            }

            if (await _supplyManagerService.SuplierExists(suplierId) == false)
            {
                return StatusCode(400);
            }

            try
            {
                await _supplyManagerService.DeleteSuplierById(suplierId);

                return StatusCode(200, true);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("delete_delivery")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteDelivery([FromQuery] int deliveryId)
        {
            if (deliveryId <= 0)
            {
                return StatusCode(400);
            }

            if (await _supplyManagerService.DeliveryExists(deliveryId) == false)
            {
                return StatusCode(400);
            }

            try
            {
                await _supplyManagerService.DeleteDeliveryById(deliveryId);

                return StatusCode(200, true);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("delete_part_order")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePartOrder([FromQuery] int partOrderId)
        {
            if (partOrderId <= 0)
            {
                return StatusCode(400);
            }

            if (await _supplyManagerService.PartOrderExists(partOrderId) == false)
            {
                return StatusCode(400);
            }

            try
            {
                await _supplyManagerService.DeletePartOrderById(partOrderId);

                return StatusCode(200, true);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("edit_delivery")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> EditDelivery([FromBody] EditDelivedryDto editDeliveryDto)
        {

            if (await _supplyManagerService.DeliveryExists(editDeliveryDto.Id) == false)
            {
                return StatusCode(400);
            }

            if (editDeliveryDto == null)
            {
                return StatusCode(400, editDeliveryDto);
            }

            if (!ModelState.IsValid)
            {
                return StatusCode(400, editDeliveryDto);
            }

            try
            {
                var result = await _supplyManagerService.EditDeliveryById(editDeliveryDto);

                if (result)
                {
                    return StatusCode(202, true);
                }

                return StatusCode(400, editDeliveryDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPut]
        [Route("edit_suplier")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> EditSuplier([FromBody] EditSuplierDto editSuplierDto)
        {

            if (await _supplyManagerService.SuplierExists(editSuplierDto.Id) == false)
            {
                return StatusCode(400);
            }

            if (editSuplierDto == null)
            {
                return StatusCode(400, editSuplierDto);
            }

            if (!ModelState.IsValid)
            {
                return StatusCode(400, editSuplierDto);
            }

            try
            {
                var result = await _supplyManagerService.EditSuplierById(editSuplierDto);

                if (result)
                {
                    return StatusCode(202, true);
                }

                return StatusCode(400, editSuplierDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("edit_part_order")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> EditPartOrder([FromBody] EditPartOrderDto editPartOrderDto)
        {

            if (await _supplyManagerService.PartOrderExists(editPartOrderDto.Id) == false)
            {
                return StatusCode(400);
            }

            if (editPartOrderDto == null)
            {
                return StatusCode(400, editPartOrderDto);
            }

            if (!ModelState.IsValid)
            {
                return StatusCode(400, editPartOrderDto);
            }

            try
            {
                var result = await _supplyManagerService.EditPartOrderById(editPartOrderDto);

                if (result)
                {
                    return StatusCode(202, true);
                }

                return StatusCode(400, editPartOrderDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("parts_in_stock")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAvaiableParts()//[FromQuery] int page = 1
        {

            //if (page <= 0)
            //{
            //    return StatusCode(400);
            //}

            try
            {
                var model = await _supplyManagerService.AllPartsInStock();//page

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
