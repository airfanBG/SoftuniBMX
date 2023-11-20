namespace BicycleApp.Services.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    using static BicycleApp.Common.EntityValidationConstants.User;

    public class ClientRegisterDto
    {
        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        [JsonProperty("firstName")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        [JsonProperty("lastName")]
        public string LastName { get; set; } = null!;

        [Required]
        [JsonProperty("email")]
        public string Email { get; set; } = null!;

        [Required]
        [JsonProperty("password")]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        [JsonProperty("repass")]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        [StringLength(IBANMaxLength)]
        [JsonProperty("iban")]
        public string IBAN { get; set; } = null!;

        [Required]
        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [Required]
        [StringLength(PhoneNumberMaxLength)]
        [JsonProperty("phone")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [JsonProperty("city")]
        public string Town { get; set; } = null!;

        [Required]
        [JsonProperty("role")]
        public string Role { get; set; } = null!;

        [Required]
        [StringLength(DelivaryAddressMaxLength)]
        [JsonProperty("address")]
        public ClientAddressDto DelivaryAddress { get; set; } = null!;
    }
}
