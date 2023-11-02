namespace BicycleApp.Data.Models.EntityModels
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    [Comment("Table with the location of all images of all parts in tha database")]
    public class ImagePart
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Name of the image")]
        public string ImageName { get; set; } = null!;

        [Required]
        [Comment("Url of the image")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Comment("Id of the part")]
        public int PartId { get; set; }

        public virtual Part Part { get; set; } = null!;
    }
}
