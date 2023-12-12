using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static BicycleApp.Common.EntityValidationConstants.Delivery;

namespace BicycleApp.Services.Models.Supply
{
    public class CreateDelivedryDto
    {
        [Required]
        [Comment("Id of the part")]
        [JsonPropertyName("part_id")]
        public int PartId { get; set; }

        [Required]
        [Precision(12, 2)]
        [Range(1.00, 10000.00)]
        [Comment("Quantity delivered of the current part")]
        [JsonPropertyName("quantity_delivered")]
        public double QuantityDelivered { get; set; }

        [MaxLength(NoteMaxLength)]
        [MinLength(NoteMinLength)]
        [Comment("Additional info for the current delivary")]
        [JsonPropertyName("note")]
        public string? Note { get; set; }

        [Required]
        [Comment("Date of the creation of the entry")]
        [JsonPropertyName("date_delivered")]
        public DateTime DateDelivered { get; set; }

        [Required]
        [Comment("Id of the suplier for this delivary")]
        [JsonPropertyName("suplier_id")]
        public int SuplierId { get; set; }
    }
}
