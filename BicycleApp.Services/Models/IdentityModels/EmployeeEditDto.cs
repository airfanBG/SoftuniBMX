namespace BicycleApp.Services.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;
    using static BicycleApp.Common.Constants.EntityValidationConstants.User;

    public class EmployeeEditDto
    {
        [Required]
        public string EmployeeId { get; set; } = null!;

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; } = null!;
    }
}
