namespace BicycleApp.Data.Models.IdentityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Models.EntityModels;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.User;

    [Comment("Table of all employees registered in the database")]
    public class Employee : BaseUser
    {
        public Employee()
        {
            this.OrdersPartsEmployees = new HashSet<OrderPartEmployee>();
            this.ImagesEmployees = new HashSet<ImageEmployee>();
        }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        [Comment("The first name of the employee")]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        [Comment("The last name of the employee")]
        public string LastName { get; set; } = null!;

        [Comment("Phone number of the employee")]
        public override string? PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        [Comment("Email of the employee")]
        public override string? Email { get => base.Email; set => base.Email = value; }

        [Required]
        [MaxLength(PositionMaxLength)]
        [Comment("Current position of the employee in the company")]
        public string Position { get; set; } = null!;

        [Required]
        [Comment("Date of hire of the employee")]
        public DateTime DateOfHire { get; set; }

        [Comment("Date of termination of the employee")]
        public DateTime? DateOfLeave { get; set; }

        [Required]
        [Comment("Status of the account: Active/Inactive")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("Date of the creation of the account")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of last update of account data")]
        public DateTime? DateUpdated { get; set; }

        [Required]
        [Comment("Id of the current department of the employee")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;

        public virtual ICollection<OrderPartEmployee> OrdersPartsEmployees { get; set; }

        [Required]
        public bool IsManeger { get; set; } = false;

        public virtual ICollection<ImageEmployee> ImagesEmployees { get; set; }
    }
}
