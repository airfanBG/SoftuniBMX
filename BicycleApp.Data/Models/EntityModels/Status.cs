namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Interfaces;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.Status;

    [Comment("Table with all the statuses for the orders")]
    public class Status : IEntity
    {
        public Status()
        {
            this.Orders = new HashSet<Order>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(StatusNameMaxLength)]
        [Comment("The name of the status")]
        public string Name { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }

        [Required]
        [Comment("Date of the creation of the status")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of last update of the status")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the status")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("State of the status: Active/Inactive")]
        public bool IsDeleted { get; set; } = false;
    }
}
