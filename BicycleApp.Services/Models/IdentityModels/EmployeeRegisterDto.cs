namespace BicycleApp.Services.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    using static BicycleApp.Common.EntityValidationConstants.User;

    public class EmployeeRegisterDto
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
        [JsonProperty("phone")]
        public string PhoneNumber { get; set; } = null!;

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
        [StringLength(PositionMaxLength, MinimumLength = PositionMinLength)]
        [JsonProperty("position")]
        public string Position { get; set; } = null!;

        [Required]
        [JsonProperty("dateOfHire")]
        public string DateOfHire { get; set; } = null!;

        [Required]
        [JsonProperty("department")]
        public string Department { get; set; } = null!;

        [Required]
        [JsonProperty("isManeger")]
        public bool IsManeger { get; set; }

        [Required]
        [JsonProperty("role")]
        public string Role { get; set; } = null!;
    }
}