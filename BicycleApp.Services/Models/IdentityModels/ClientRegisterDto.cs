namespace BicycleApp.Services.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    using static BicycleApp.Common.EntityValidationConstants.User;

    public class ClientRegisterDto
    {
        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; } = null!;

        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; } = null!;

        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        [JsonPropertyName("repass")]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        [StringLength(IBANMaxLength)]
        [JsonPropertyName("iban")]
        public string IBAN { get; set; } = null!;

        [Required]
        [JsonPropertyName("balance")]
        public decimal Balance { get; set; }

        [Required]
        [StringLength(PhoneNumberMaxLength)]
        [JsonPropertyName("phone")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [JsonPropertyName("city")]
        public string Town { get; set; } = null!;

        [Required]
        [JsonPropertyName("role")]
        public string Role { get; set; } = null!;

        [Required]
        //[StringLength(DelivaryAddressMaxLength)]
        [JsonPropertyName("address")]
        public ClientAddressDto DelivaryAddress { get; set; } = null!;
    }
}
