namespace BicicleApp.Api.Controllers
{
    using BicycleApp.Services.Contracts;
    using BicycleApp.Services.Models.Rating;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/rate")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;
        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost]
        [Route("rate")]
        public async Task<IActionResult> SetRating([FromBody] RatingDto rating)
        {
           var result = await _ratingService.SetRating(rating);
            if (result)
            {
                return Ok();
            }
            return StatusCode(500);            
        }

        [HttpGet]
        [Route("rate")]
        public async Task<ActionResult<double>> GetRate([FromQuery] int partId)
        {
            var result = await _ratingService.GetAverageRatePerPart(partId);
            if (result>=0)
            {
                return Ok(result);
            }
            return StatusCode(500);
        }

        [HttpPatch]
        [Route("rate")]
        public async Task<IActionResult> UpdateRating([FromBody] RatingDto rating)
        {
            var result = await _ratingService.UpdateRating(rating);
            if (result)
            {
                return Ok();
            }
            return StatusCode(500);
        }

        [HttpDelete]
        [Route("rate")]
        public async Task<IActionResult> RemoveRating([FromBody] RatingDto rating)
        {
            var result = await _ratingService.RemoveRating(rating);
            if (result)
            {
                return Ok();
            }
            return StatusCode(500);
        }

    }
}
