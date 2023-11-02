namespace BicycleApp.Data.Models.EntityModels
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.EntityFrameworkCore;

    [Comment("Table of all delivaries of all parts in the database")]
    public class Delivary
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Id of the part")]
        public int PartId { get; set; }

        public virtual Part Part { get; set; } = null!;

        [Required]
        [Comment("Quantity delivered of the current part")]
        public double QuantityDelivered { get; set; }

        [Comment("Additional info for the current delivary")]
        public string? Note { get; set; }

        [Required]
        [Comment("Date of the creation of the entry")]
        public DateTime DateDelivered { get; set; }

        [Comment("Date of last update of the entry")]
        public DateTime? DateUpdated { get; set; }

        [Required]
        [Comment("Id of the suplier for this delivary")]
        public int SuplierId { get; set; }

        public virtual Suplier Suplier { get; set; } = null!;
    }
}
