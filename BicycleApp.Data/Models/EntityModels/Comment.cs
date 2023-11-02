namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Models.IdentityModels;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.Coment;

    [Comment("Table of all comments for all parts in the database")]
    public class Comment
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Id of the part")]
        public int PartId { get; set; }

        public virtual Part Part { get; set; } = null!;

        [Required]
        public string ClientId { get; set; } = null!;

        public virtual Client Client { get; set; } = null!;

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Title of the comment")]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Description of the comment")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("Date of the creation of the comment")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of last update of the comment")]
        public DateTime? DateUpdated { get; set; }
    }
}
