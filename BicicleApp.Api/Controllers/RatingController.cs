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
        [Route("set_rate")]
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
        [Route("get_rate")]
        public async Task<ActionResult<bool>> GetRate([FromQuery] int partId, [FromQuery] string clientId)
        {
            var result = await _ratingService.ClientRateExists(partId, clientId);
            if (result)
            {
                return Ok(result);
            }
            return StatusCode(500);
        }

        [HttpPut]
        [Route("update_rate")]
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
        [Route("delete_rate")]
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
