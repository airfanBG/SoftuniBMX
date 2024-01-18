namespace BicycleApp.Services.Models.Rating
{
    using BicycleApp.Services.Models.Rating.Contracts;
    using System.ComponentModel.DataAnnotations;
    using static BicycleApp.Common.Constants.EntityValidationConstants;

    public class RatingDto : IRatingDto
    {
        public string ClientId { get; set; } = null!;
        public int PartId { get; set; }

        [Range(Rate.RateMinValue, Rate.RateMaxValue)]
        public int Rating { get; set; }
    }
}
