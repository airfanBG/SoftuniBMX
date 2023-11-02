namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using BicycleApp.Data.Models.IdentityModels;

    using Microsoft.EntityFrameworkCore;

    [Comment("Table with the location of all images of all clients in tha database")]
    public class ImageClient
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
        public string ClientId { get; set; } = null!;

        public virtual Client Client { get; set; } = null!;
    }
}
