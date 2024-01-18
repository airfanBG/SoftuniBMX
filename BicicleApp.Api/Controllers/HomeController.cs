namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.HomePage;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/home")]
    [ApiController]
    [Authorize]
    public class HomeController : ControllerBase
    {
        private readonly IHomePageService homePageService;

        public HomeController(IHomePageService homePageService)
        {
            this.homePageService = homePageService;
        }

        [HttpGet]
        [Route("index")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IndexPageDto>> Index()
        {
            try
            {
                var httpScheme = Request.Scheme;
                var httpHost = Request.Host.Value;
                var httpPathBase = Request.PathBase;
                IndexPageDto? dto = await homePageService.GetIndexPageData(httpScheme, httpHost, httpPathBase);
             
                if (dto == null)
                {
                    return NoContent();
                }

                return Ok(dto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}