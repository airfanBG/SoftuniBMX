namespace BicycleApp.Data.Models.EntityModels
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static BicycleApp.Common.EntityValidationConstants.BikeModel;

    public class BikeStandartModel
    {
        public BikeStandartModel()
        {
            this.BikeModelsParts = new HashSet<BikeModelPart>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Name of standart bike.")]
        [MaxLength(BikeModelNameMaxLength)]
        public string ModelName { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        public virtual ICollection<BikeModelPart> BikeModelsParts { get; set; }

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
