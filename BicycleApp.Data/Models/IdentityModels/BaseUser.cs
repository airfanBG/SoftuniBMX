namespace BicycleApp.Data.Models.IdentityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using static BicycleApp.Common.EntityValidationConstants.User;

    public class BaseUser : IdentityUser
    {
        public BaseUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityRole>();
        }

        [MaxLength(FirstNameMaxLength)]
        [Comment("The first name of the user")]
        public string? FirstName { get; set; }

        [MaxLength(LastNameMaxLength)]
        [Comment("The last name of the user")]
        public string? LastName { get; set; }

        [Required]
        [Comment("Status of the account: Active/Inactive")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("Date of the creation of the account")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of last update of account data")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the account")]
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<IdentityRole> Roles { get; set; }
    }
}
