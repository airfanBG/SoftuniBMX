namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Interfaces;

    using Microsoft.EntityFrameworkCore;

    [Comment("Table of all vat categories in the database")]
    public class VATCategory : IEntity
    {
        public VATCategory()
        {
            this.Parts = new HashSet<Part>();    
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Current percent of the VAT for this category parts")]
        public decimal VATPercent { get; set; }

        public virtual ICollection<Part> Parts { get; set; }

        [Required]
        [Comment("Date of the creation of the category")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of the last update of the category")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the category")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("Status of the category: Active/Inactive")]
        public bool IsDeleted { get; set; } = false;
    }
}
