namespace BicycleApp.Services.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    using static BicycleApp.Common.Constants.EntityValidationConstants.User;

    public class ClientBankDto
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [MaxLength(IBANMaxLength)]
        [JsonProperty("iban")]
        public string? IBAN { get; set; }

        [Required]
        [JsonProperty("balance")]
        [Range(0, double.MaxValue)]
        public decimal Balance { get; set; }
    }
}
