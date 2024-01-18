namespace BicycleApp.Services.Models.Comment
{
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    using static BicycleApp.Common.Constants.EntityValidationConstants.Coment;

    public class CommentAddDto
    {
        [Required]
        [JsonProperty("partId")]
        public int PartId { get; set; }

        [Required]
        [JsonProperty("clientId")]
        public string ClientId { get; set; } = null!;

        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        [JsonProperty("title")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        [JsonProperty("description")]
        public string Description { get; set; } = null!;
    }
}
