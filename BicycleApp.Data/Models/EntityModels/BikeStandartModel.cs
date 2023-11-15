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

        [Comment("Image of standart bike.")]
        public string? ImageUrl { get; set; }

        public virtual ICollection<BikeModelPart> BikeModelsParts { get; set; }
    }
}
