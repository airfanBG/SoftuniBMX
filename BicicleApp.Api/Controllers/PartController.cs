namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/part")]
    [ApiController]
    public class PartController : ControllerBase
    {
        private readonly IPartService partService;

        public PartController(IPartService partService)
        {
            this.partService = partService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PartGetDto>> GetData()
        {
            try
            {
                var result = await partService.GetCategoties();
                return Ok(result);
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
        public async Task<ActionResult> AddPart([FromBody] PartAddDto partAddDto)
        {
            if (partAddDto == null)
            {
                return BadRequest(partAddDto);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(partAddDto);
            }

            try
            {
                var result = await partService.AddNewPart(partAddDto);
                if (result)
                {
                    return StatusCode(201);
                }

                return BadRequest(partAddDto);
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
        public async Task<ActionResult> EditPart([FromBody] PartEditDto partEditDto)
        {
            if (partEditDto == null)
            {
                return BadRequest(partEditDto);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(partEditDto);
            }

            try
            {
                var result = await partService.EditPart(partEditDto);
                if (result)
                {
                    return StatusCode(202);
                }

                return BadRequest(partEditDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("find")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PartFullInfoDto>> GetPartById([FromQuery] int partId)
        {
            if (partId == null)
            {
                return BadRequest(partId);
            }

            try
            {
                var part = await partService.GetPartById(partId);

                if (part == null)
                {
                    return NotFound(partId);
                }

                return Ok(part);
            }
            catch (Exception)
            {
                return StatusCode(500, partId);
            }
        }
    }
}
