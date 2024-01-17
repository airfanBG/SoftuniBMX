using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace BicycleApp.Data.Models.EntityModels
{
    public class PartInStock
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Id of the part")]
        public int PartId { get; set; }
        public virtual Part Part { get; set; } = null!;

        [Required]
        [Comment("Id of the suplier for this part")]
        public int SuplierId { get; set; }

        [Required]
        [Comment("Date of the creation of the entry")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of last update of the entry")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the entry")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("Status of the entry: Active/Inactive")]
        public bool IsDeleted { get; set; } = false;
    }
}
