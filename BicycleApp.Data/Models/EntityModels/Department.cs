namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Interfaces;
    using BicycleApp.Data.Models.IdentityModels;

    using Microsoft.EntityFrameworkCore;

    using static BicycleApp.Common.EntityValidationConstants.Department;


    [Comment("Table of all departments in the database")]
    public class Department : IEntity
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DepartmentNameMaxLength)]
        [Comment("The name of the department")]
        public string Name { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }

        [Required]
        [Comment("Date of the creation of the entity")]
        public DateTime DateCreated { get; set; }

        [Comment("Date of the last update of the entity")]
        public DateTime? DateUpdated { get; set; }

        [Comment("Date of deletion of the entity")]
        public DateTime? DateDeleted { get; set; }

        [Required]
        [Comment("Status of the department: Active/Inactive")]
        public bool IsDeleted { get; set; } = false;
    }
}
