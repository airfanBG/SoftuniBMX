namespace BicycleApp.Data.Models.EntityModels
{
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Models.IdentityModels;

    using Microsoft.EntityFrameworkCore;

    [Comment("Table of all the ratings for all the part in the database")]
    public class Rate
    {
        [Required]
        [Comment("Id of the client who has rated the current part")]
        public string ClientId { get; set; } = null!;

        public virtual Client Client { get; set; } = null!;

        [Required]
        [Comment("Id of the part who has the client rated")]
        public int PartId { get; set; }

        public virtual Part Part { get; set; } = null!;

        [Required]
        [Comment("The last rating for the part given by the client")]
        public int Rating { get; set; }

        [Required]
        [Comment("Date of the creation of the order")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of the completion of the order")]
        public DateTime? DateFinish { get; set; }

        [Comment("Date of last update of the order")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the order")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("Is the order deleted: Yes/No")]
        public bool IsDeleted { get; set; } = false;
    }
}
