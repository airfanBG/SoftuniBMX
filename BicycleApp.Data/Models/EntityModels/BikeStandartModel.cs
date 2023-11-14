namespace BicycleApp.Data.Models.EntityModels
{
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
        [MaxLength(BikeModelNameMaxLength)]
        public string ModelName { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public virtual ICollection<BikeModelPart> BikeModelsParts { get; set; }
    }
}
