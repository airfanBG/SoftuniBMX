namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Interfaces;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.Suplier;

    [Comment("Table of all supliers in the database")]
    public class Suplier : IEntity
    {
        public Suplier()
        {
            this.Delivaries = new HashSet<Delivary>();
            this.PartsInStock = new HashSet<PartInStock>();
            this.PartsInOrder = new HashSet<PartOrder>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(SuplierNameMaxLength)]
        [Comment("The name of the firm")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(VATNumberMaxLength)]
        [Comment("Unique VAT number of the suplier")]
        public string VATNumber { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        [Comment("Main address of the suplier")]
        public string Address { get; set; } = null!;

        [MaxLength(PhoneNumberMaxLength)]
        [Comment("Main phone number of the supplier")]
        public string? PhoneNumeber { get; set; }

        [MaxLength(EmailMaxLength)]
        [Comment("Main email of the suplier")]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        [Comment("The category name of the suplied part")]
        public string CategoryName { get; set; } = null!;

        [Required]
        [MaxLength(ContactNameMaxLength)]
        [Comment("The name of the main person for contact with the suplier")]
        public string ContactName { get; set; } = null!;

        public virtual ICollection<Delivary> Delivaries { get; set; }
        public virtual ICollection<PartInStock> PartsInStock { get; set; }
        public virtual ICollection<PartOrder> PartsInOrder { get; set; }

        [Required]
        [Comment("Date of the creation of the entry")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of last update of the entry")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the entry")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("Status of the entry: Active/Inactive")]
        public bool IsDeleted { get; set; } = false;
    }
}
