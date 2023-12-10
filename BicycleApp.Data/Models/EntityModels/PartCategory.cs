namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Interfaces;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.PartCategory;

    [Comment("Table of all categories for a part in the database")]
    public class PartCategory : IEntity
    {
        public PartCategory()
        {
            this.Parts = new HashSet<Part>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(PartCategoryNameMaxLength)]
        [Comment("Name of the category")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Url of the general image for this category")]
        public string ImageUrl { get; set; } = null!;

        public virtual ICollection<Part> Parts { get; set; }

        [Required]
        [Comment("Date of the creation of the category")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of last update of the category")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the category")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("Status of the category: Active/Inactive")]
        public bool IsDeleted { get; set; } = false;
    }
}
