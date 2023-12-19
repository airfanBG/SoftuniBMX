namespace BicycleApp.Services.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;
    using static BicycleApp.Common.EntityValidationConstants.User;

    public class EmployeeRegisterDto
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
        [JsonPropertyName("phone")]
        public string PhoneNumber { get; set; } = null!;

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
        [StringLength(PositionMaxLength, MinimumLength = PositionMinLength)]
        [JsonPropertyName("position")]
        public string Position { get; set; } = null!;

        [Required]
        [JsonPropertyName("dateOfHire")]
        public string DateOfHire { get; set; } = null!;

        [Required]
        [JsonPropertyName("department")]
        public string Department { get; set; } = null!;

        [Required]
        [JsonPropertyName("isManeger")]
        public bool IsManeger { get; set; }

        [Required]
        [JsonPropertyName("role")]
        public string Role { get; set; } = null!;
    }
}