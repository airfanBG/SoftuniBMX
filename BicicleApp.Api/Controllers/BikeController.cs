namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/bike")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        private readonly IBikeService bikeService;

        public BikeController(IBikeService bikeService)
        {
            this.bikeService = bikeService;
        }

        [HttpGet]
        [Route("parts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<PartShortInfoDto>>> GetAllParts()
        {
            try
            {
                var model = await bikeService.GetAllParts();
                return Ok(model);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("add")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddBikeModel([FromBody] BikeStandartTypeAddDto bikeStandartTypeAddDto)
        {
            if (bikeStandartTypeAddDto == null)
            {
                return BadRequest(bikeStandartTypeAddDto);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(bikeStandartTypeAddDto);
            }

            try
            {
                var result = await bikeService.AddBikeModelAsync(bikeStandartTypeAddDto);
                if (result)
                {
                    return StatusCode(201);   
                }

                return BadRequest(bikeStandartTypeAddDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("edit")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> EditBikeModel([FromBody] BikeStandartTypeEditDto bikeStandartTypeEditDto)
        {
            if (bikeStandartTypeEditDto == null)
            {
                return BadRequest(bikeStandartTypeEditDto);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(bikeStandartTypeEditDto);
            }

            try
            {
                var result = await bikeService.EditBikeModelAsync(bikeStandartTypeEditDto);
                if (result)
                {
                    return StatusCode(202);
                }

                return BadRequest(bikeStandartTypeEditDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
