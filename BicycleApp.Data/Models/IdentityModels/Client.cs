namespace BicycleApp.Data.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Models.EntityModels;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.User;

    [Comment("Table of all clients registered in the database")]
    public class Client : BaseUser
    {
        public Client()
        {
            this.Rates = new HashSet<Rate>();
            this.Comments = new HashSet<Comment>();
            this.Orders = new HashSet<Order>();
        }

        [MaxLength(FirstNameMaxLength)]
        [Comment("The first name of the client")]
        public string? FirstName { get; set; }

        [MaxLength(LastNameMaxLength)]
        [Comment("The last name of the client")]
        public string? LastName { get; set; }

        [MaxLength(PhoneNumberMaxLength)]
        public override string? PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        [MaxLength(DelivaryAddressMaxLength)]
        [Comment("The default address of the client for deliveries")]
        public string DelivaryAddress { get; set; } = null!;

        [Comment("The Id of the default town for this client")]
        public int TownId { get; set; }

        public virtual Town Town { get; set; } = null!;

        [MaxLength(IBANMaxLength)]
        [Comment("IBAN of the client")]
        public string? IBAN { get; set; }

        [Required]
        [Comment("The amount of the deposited money in this client account")]
        public decimal Balance { get; set; } = 0.00M;

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

        public virtual ICollection<Rate> Rates { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
