namespace BicycleApp.Data.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Models.EntityModels;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.User;

    public class Client : BaseUser
    {
        public Client()
        {
            this.Rates = new HashSet<Rate>();
            this.Comments = new HashSet<Comment>();
            this.Orders = new HashSet<Order>();
            this.Images = new HashSet<ImageClient>();
        }


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

        public virtual ICollection<Rate> Rates { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<ImageClient> Images { get; set; }
    }
}
