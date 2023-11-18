namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/home")]
    [ApiController]
    [Authorize]
    public class HomeController : ControllerBase
    {
        private readonly IHomePageService homePageService;
        private readonly IHttpContextAccessor httpContext;

        public HomeController(IHomePageService homePageService, IHttpContextAccessor httpContext)
        {
            this.homePageService = homePageService;
            this.httpContext = httpContext;
        }

        [HttpGet(Name = "index")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IndexPageDto>> Index()
        {
            try
            {
                IndexPageDto? dto;
                if (httpContext.HttpContext?.User?.Identity?.IsAuthenticated ?? false)
                {
                    string userId = httpContext.HttpContext.User.FindFirst("UserId")!.Value;
                    dto = await homePageService.GetIndexPageData(userId);
                }
                else
                {
                    dto = await homePageService.GetIndexPageData();
                }

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