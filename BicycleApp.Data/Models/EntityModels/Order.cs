namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Interfaces;
    using BicycleApp.Data.Models.IdentityModels;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.Order;

    [Comment("Table of all orders from clients in the database")]
    public class Order : IEntity
    {
        public Order()
        {
            this.OrdersPartsEmployees = new HashSet<OrderPartEmployee>();    
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(SerialNumberLength)]
        [Comment("Unique serial number of the order")]
        public string SerialNumber { get; set; } = null!;

        [Required]
        [Comment("Id of the client of this order")]
        public string ClientId { get; set; } = null!;

        public virtual Client Client { get; set; } = null!;

        [Required]
        [Comment("All information of the ordered parts from the client, as a string")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("The amount of the order before discount and tax")]
        public decimal SaleAmount { get; set; }

        [Required]
        [Comment("The amount of the discoint")]
        public decimal Discount { get; set; }

        [Required]
        [Comment("The amount of the VAT")]
        public decimal VAT { get; set; }

        [Required]
        [Comment("The final amount of the order after discount and tax")]
        public decimal FinalAmount { get; set; }

        [Required]
        [Comment("The amount paid from this order")]
        public decimal PaidAmount { get; set; }

        [Required]
        [Comment("The amount not paid from this order")]
        public decimal UnpaidAmount { get; set; }

        [Required]
        [Comment("Date of the creation of the order")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of the completion of the order")]
        public DateTime? DateFinish { get; set; }

        [Comment("Date of last update of the order")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the order")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("Is the order deleted: Yes/No")]
        public bool IsDeleted { get; set; } = false;

        [Required]
        [Comment("Id of the current status of the order")]
        public int StatusId { get; set; }

        public virtual Status Status { get; set; } = null!;

        public virtual ICollection<OrderPartEmployee> OrdersPartsEmployees { get; set; }
    }
}
