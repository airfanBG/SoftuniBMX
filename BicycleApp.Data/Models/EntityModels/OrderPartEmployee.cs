namespace BicycleApp.Data.Models.EntityModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BicycleApp.Data.Models.IdentityModels;
    using static BicycleApp.Common.EntityValidationConstants.Order;

    using Microsoft.EntityFrameworkCore;
    using BicycleApp.Data.Interfaces;

    [Comment("Table conecting all the parts in an order with the employee responsible for the mounting")]
    public class OrderPartEmployee
    {
        [Required]
        [Comment("Id of the order from the client")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; } = null!;

        [Required]
        [Comment("Separate unique products by serial number in one order")]
        public string UniqueKeyForSerialNumber { get; set; } = null!;

        [Required]
        [MaxLength(SerialNumberLength)]
        [Comment("Unique serial number of the order")]
        public string SerialNumber { get; set; } = null!;

        [Required]
        [Comment("Id of the part")]
        public int PartId { get; set; }

        public virtual Part Part { get; set; } = null!;

        [Required]
        [Comment("Name of the part")]
        public string PartName { get; set; } = null!;

        [Required]
        [Comment("Quantity of the part")]
        public int PartQuantity { get; set; }

        [Required]
        [Comment("Price of the part")]
        public decimal PartPrice { get; set; }
        
        [Comment("Id of the emplyee asigned to this order")]
        public string? EmployeeId { get; set; } 

        public virtual Employee? Employee { get; set; }
                
        [Comment("Date and time of asigned task to the employee")]
        public DateTime? DatetimeAsigned { get; set; }

        [Comment("Date and time of start of the task from the employee")]
        public DateTime? StartDatetime { get; set; }

        [Comment("Date and time of finish of the task from the employee")]
        public DateTime? EndDatetime { get; set; }

        [Comment("Description of the task")]
        public string? Description { get; set; }

        [Required]
        [Comment("Status of the task: Completed/Not completed")]
        public bool IsCompleted { get; set; } = false;

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
    }
}
