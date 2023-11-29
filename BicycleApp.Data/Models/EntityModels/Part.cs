namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Interfaces;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.Part;

    [Comment("Table of all the parts in the database")]
    public class Part : IEntity
    {
        public Part()
        {
            this.ImagesParts = new HashSet<ImagePart>();
            this.Delivaries = new HashSet<Delivary>();
            this.Comments = new HashSet<Comment>();
            this.OrdersPartsEmployees = new HashSet<OrderPartEmployee>();
            this.Rates = new HashSet<Rate>();
            this.BikeModelsParts = new HashSet<BikeModelPart>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(PartNameMaxLength)]
        [Comment("The name of the part")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(PartDescriptionMaxLength)]
        [Comment("Full description of the part")]
        public string Description { get; set; }

        [Required]
        [MaxLength(PartIntetionMaxLength)]
        [Comment("Intention of the part")]
        public string Intend { get; set; }

        [MaxLength(PartOEMMaxLength)]
        [Comment("Unique number of the part from the manifacturer")]
        public string? OEMNumber { get; set; }

        [Required]
        [Comment("Type of the part")]
        public int Type { get; set; }

        [Required]
        [Comment("Id of the category of the part")]
        public int CategoryId { get; set; }

        public virtual PartCategory Category { get; set; } = null!;

        [Required]
        [Comment("Current quantity of the part in the database")]
        public double Quantity { get; set; }

        public virtual ICollection<ImagePart> ImagesParts { get; set; }

        [Required]
        [Comment("Sale price of the part before VAT")]
        public decimal SalePrice { get; set; } = 0.00M;
                
        [Comment("Discount for part")]
        public decimal Discount { get; set; } = 0.00M;

        [Required]
        [Comment("Id of the current vat category of the part")]
        public int VATCategoryId { get; set; }

        public virtual VATCategory VATCategory { get; set; } = null!;

        public virtual ICollection<Delivary> Delivaries { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public ICollection<CompatablePart> CompatableParts { get; set; } = new List<CompatablePart>();

        public virtual ICollection<OrderPartEmployee> OrdersPartsEmployees { get; set; }

        public virtual ICollection<Rate> Rates { get; set; }

        [Required]
        [Comment("Date of the creation of the entry in tha database")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of the last update of the entry in the database")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the entry from the database")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("Status of the part: Deleted/Not deleted")]
        public bool IsDeleted { get; set; } = false;

        public virtual ICollection<BikeModelPart> BikeModelsParts { get; set; }
    }
}
