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


        [Required]
        [Comment("Date of the creation of the entity")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of the last update of the entity")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of deletion of the entity")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("Status of the department: Active/Inactive")]
        public bool IsDeleted { get; set; } = false;
    }
}
