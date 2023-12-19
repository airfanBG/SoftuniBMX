namespace BicycleApp.Data.Models.EntityModels
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class OrderPartEmployeeInfo
    {
        [Key]
        [Comment("Id of information for manufacturing part.")]
        public int Id { get; set; }
        
        [Comment("Id of the order from the quality control")]
        public string? DescriptionForWorker { get; set; }

        [Required]
        [Comment("Timespan for production on part.")]
        public TimeSpan ProductionТime { get; set; }

        [Required]
        [Comment("Id of the order from the client")]
        public int OrderId { get; set; }
        [Required]
        [Comment("Separate unique products by serial number in one order")]
        public string UniqueKeyForSerialNumber { get; set; } = null!;

        [Required]
        [Comment("Id of the part")]        
        public int PartId { get; set; }
        [Required]
        public virtual OrderPartEmployee OrderPartEmployee { get; set; } = null!;
    }
}
