using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static BicycleApp.Common.EntityValidationConstants.Delivery;

namespace BicycleApp.Services.Models.Supply
{
    public class CreateDelivedryDto
    {

        [Required]
        [Comment("Id of the part")]
        public int PartId { get; set; }

        [Required]
        [Precision(12, 2)]
        [Range(1.00, 10000.00)]
        [Comment("Quantity delivered of the current part")]
        public double QuantityDelivered { get; set; }

        [MaxLength(NoteMaxLength)]
        [MinLength(NoteMinLength)]
        [Comment("Additional info for the current delivary")]
        public string? Note { get; set; }

        [Required]
        [Comment("Date of the creation of the entry")]
        public DateTime DateDelivered { get; set; }

        [Required]
        [Comment("Id of the suplier for this delivary")]
        public int SuplierId { get; set; }
    }
}
