using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace BicycleApp.Data.Models.EntityModels
{
    public class PartInStock
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Unic number of the part")]
        public string OemPartNumber { get; set; } = null!;

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

        //[Required]
        //[Comment("Id of the suplier for this delivary")]-without this FK the SuplierId exists and is set to null
        //public int SuplierId { get; set; }
        //public virtual Suplier Suplier { get; set; } = null!;
    }
}
