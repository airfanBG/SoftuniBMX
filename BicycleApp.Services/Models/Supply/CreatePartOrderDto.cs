using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static BicycleApp.Common.EntityValidationConstants.Delivery;

namespace BicycleApp.Services.Models.Supply
{
    public class CreatePartOrderDto
    {
        [Required]
        [Comment("Id of the part")]
        [JsonPropertyName("part_id")]
        public int PartId { get; set; }

        [Required]
        [Comment("Quantity ordered of the current part")]
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [MaxLength(NoteMaxLength)]
        [MinLength(NoteMinLength)]
        [Comment("Additional info for the current delivary")]
        [JsonPropertyName("note")]
        public string? Note { get; set; }

        [Required]
        [Comment("Id of the suplier for this delivary")]
        [JsonPropertyName("suplier_id")]
        public int SuplierId { get; set; }
    }
}

