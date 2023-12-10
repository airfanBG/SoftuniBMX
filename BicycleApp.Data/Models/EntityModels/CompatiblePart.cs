namespace BicycleApp.Data.Models.EntityModels
{
    using Microsoft.EntityFrameworkCore;

    using System.ComponentModel.DataAnnotations;

    using static BicycleApp.Common.EntityValidationConstants.CompatiblePart;

    public class CompatablePart
    {
        public CompatablePart()
        {
            this.Parts = new HashSet<Part>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CompatiblePartNameMinLength)]
        [Comment("The name of the compatible part")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("Type of the part")]
        public int Type { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}
