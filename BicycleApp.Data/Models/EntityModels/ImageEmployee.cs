namespace BicycleApp.Data.Models.EntityModels
{
    using System.ComponentModel.DataAnnotations;
    using BicycleApp.Data.Interfaces;
    using BicycleApp.Data.Models.IdentityModels;

    using Microsoft.EntityFrameworkCore;

    [Comment("Table with the location of all images of all employees in tha database")]
    public class ImageEmployee : IUserImage
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
        [Comment("Id of the client")]
        public string UserId { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;
    }
}
