using BicycleApp.Services.Contracts;
using BicycleApp.Services.Models;
using BicycleApp.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.FileIO;
using System.Reflection.Metadata.Ecma335;

namespace BicicleApp.Api.Controllers
{
    [Route("api/[controller]")]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFrames()
        {

            try
            {
                var model = await _dropdownsContentService.GetAllFrames();

                return Ok(model);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }  
        }
    }
}
