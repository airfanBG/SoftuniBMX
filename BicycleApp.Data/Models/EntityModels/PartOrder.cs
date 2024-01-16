namespace BicycleApp.Data.Models.EntityModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    [Comment("Table of all orders of parts in the database")]
    public class PartOrder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Id of the part")]
        public int PartId { get; set; }

        public virtual Part Part { get; set; } = null!;

        [Required]
        [Comment("Quantity delivered of the current part")]
        public int Quantity { get; set; }

        [Comment("Additional info for the current order")]
        public string? Note { get; set; } 

        [Required]
        [Comment("Id of the suplier for this delivary")]
        public int SuplierId { get; set; }
        public virtual Suplier Suplier { get; set; } = null!;

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
