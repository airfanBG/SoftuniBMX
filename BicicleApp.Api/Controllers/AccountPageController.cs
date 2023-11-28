using BicycleApp.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BicicleApp.Api.Controllers
{
    [Route("api/accountpage")]
    [ApiController]
    [Authorize]
    public class AccountPageController : ControllerBase
    {
        private readonly IDropdownsContentService _dropdownsContentService;

        public AccountPageController(IDropdownsContentService dropdownsContentService)
        {
            _dropdownsContentService = dropdownsContentService;
        }

        [HttpGet]
        [Route("frames")]
        [AllowAnonymous]//If I have to check if user is autorized and how (this page is for loged in users)!?
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFrames()
        {

            try
            {
                var model = await _dropdownsContentService.GetAllFrames();

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

        [HttpGet]
        [Route("compatible_parts")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCompatibleParts([FromQuery] int id)
        {

            try
            {
                var model = await _dropdownsContentService.GetAllCompatibleParts(id);

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

        [HttpGet]
        [Route("selected_part")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] 
        public async Task<IActionResult> GetPartByIdAsync([FromQuery] int id)
        {

            try
            {
                if (id <= 0)
                {
                    // The id is not valid, so return a 400 Bad Request response
                    return BadRequest();
                }

                var model = await _dropdownsContentService.GetPartByIdAsync(id);

                return Ok(model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
