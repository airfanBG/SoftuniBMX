namespace BicycleApp.Data.Models.EntityModels
{
    using BicycleApp.Data.Interfaces;
    using BicycleApp.Data.Models.IdentityModels;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    [Comment("Table with the location of all images of all clients in tha database")]
    public class ImageClient : IUserImage
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

        public virtual Client Client { get; set; } = null!;
    }
}
