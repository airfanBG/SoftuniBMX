using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static BicycleApp.Common.EntityValidationConstants.Suplier;

namespace BicycleApp.Services.Models.Supply
{
    public class CreateSuplierDto
    {
        [Required]
        [MaxLength(SuplierNameMaxLength)]
        [MinLength(SuplierNameMinLength)]
        [Comment("The name of the firm")]
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(VATNumberMaxLength)]
        [MinLength(VATNumberMinLength)]
        [Comment("Unique VAT number of the suplier")]
        [JsonPropertyName("vat_number")]
        public string VATNumber { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        [MinLength(AddressMinLength)]
        [Comment("Main address of the suplier")]
        [JsonPropertyName("address")]
        public string Address { get; set; } = null!;

        [MaxLength(PhoneNumberMaxLength)]
        [MinLength(PhoneNumberMinLength)]
        [Comment("Main phone number of the supplier")]
        [JsonPropertyName("phone_number")]
        public string? PhoneNumeber { get; set; }

        [MaxLength(EmailMaxLength)]
        [MinLength(EmailMinLength)]
        [Comment("Main email of the suplier")]
        [JsonPropertyName("email")]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(ContactNameMaxLength)]
        [MinLength(ContactNameMinLength)]
        [Comment("The name of the main person for contact with the suplier")]
        [JsonPropertyName ("contact_name")]
        public string ContactName { get; set; } = null!;

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        [MinLength(CategoryNameMinLength)]
        [Comment("The name of the category parts that suplier syply")]
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; } = null!;
    }
}
