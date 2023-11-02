namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Interfaces;
    using BicycleApp.Data.Models.IdentityModels;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.Town;

    [Comment("Table of all towns registered in the database")]
    public class Town : IEntity
    {
        public Town()
        {
            this.Clients = new HashSet<Client>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TownNameMaxLength)]
        [Comment("Name of the town")]
        public string Name { get; set; } = null!;

        public virtual ICollection<Client> Clients { get; set; }

        [Required]
        [Comment("Date of the creation of the town entry")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of last update of the town entry")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of the deletion of the town entry")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}
