using System.ComponentModel.DataAnnotations;
namespace BicycleApp.Services.Models.IdentityModels
{
    using static BicycleApp.Common.EntityValidationConstants.User;

    public class EmployeeRegisterDto
    {

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        [StringLength(PositionMaxLength, MinimumLength = PositionMinLength)]
        public string Position { get; set; } = null!;


        [Required]
        public string DateOfHire { get; set; } = null!;

        [Required]
        public string Department { get; set; } = null!;

        [Required]
        public bool IsManeger { get; set; }
    }
}
