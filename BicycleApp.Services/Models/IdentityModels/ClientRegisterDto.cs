namespace BicycleApp.Services.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    using static BicycleApp.Common.EntityValidationConstants.User;

    public class ClientRegisterDto
    {
        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        [StringLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(DelivaryAddressMaxLength)]
        public string DelivaryAddress { get; set; } = null!;

        [Required]
        public string Town { get; set; } = null!;

        [Required]
        [StringLength(IBANMaxLength)]
        public string IBAN { get; set; } = null!;

        [Required]
        public decimal Balance { get; set; }
    }
}
