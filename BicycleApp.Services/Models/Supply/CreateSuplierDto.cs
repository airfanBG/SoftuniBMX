using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

using static BicycleApp.Common.EntityValidationConstants.Suplier;

namespace BicycleApp.Services.Models.Supply
{
    public class CreateSuplierDto
    {
        [Required]
        [MaxLength(SuplierNameMaxLength)]
        [MinLength(SuplierNameMinLength)]
        [Comment("The name of the firm")]
        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(VATNumberMaxLength)]
        [MinLength(VATNumberMinLength)]
        [Comment("Unique VAT number of the suplier")]
        [JsonProperty("vat_number")]
        public string VATNumber { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        [MinLength(AddressMinLength)]
        [Comment("Main address of the suplier")]
        [JsonProperty("address")]
        public string Address { get; set; } = null!;

        [MaxLength(PhoneNumberMaxLength)]
        [MinLength(PhoneNumberMinLength)]
        [Comment("Main phone number of the supplier")]
        public string? PhoneNumeber { get; set; }

        [MaxLength(EmailMaxLength)]
        [MinLength(EmailMinLength)]
        [Comment("Main email of the suplier")]
        [JsonProperty("email")]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(ContactNameMaxLength)]
        [MinLength(ContactNameMinLength)]
        [Comment("The name of the main person for contact with the suplier")]
        [JsonProperty ("contact_name")]
        public string ContactName { get; set; } = null!;
    }
}
