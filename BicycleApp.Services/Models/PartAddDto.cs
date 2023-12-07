namespace BicycleApp.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    using static BicycleApp.Common.EntityValidationConstants.Part;

    public class PartAddDto
    {

        [Required]
        [StringLength(PartNameMaxLength, MinimumLength = PartNameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(PartDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(PartIntetionMaxLength)]
        public string Intend { get; set; } = null!;

        [StringLength(PartOEMMaxLength)]
        public string? OEMNumber { get; set; }

        [Required]
        public int Type { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public double Quantity { get; set; }

        [Required]
        public decimal SalePrice { get; set; } = 0.00M;

        [Required]
        public int VATCategoryId { get; set; }
    }
}
