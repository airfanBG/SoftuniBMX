namespace BicycleApp.Services.Models.Order
{
    using System.ComponentModel.DataAnnotations;
    using static BicycleApp.Common.EntityValidationConstants;

    public class EmployeePartTaskDto
    {
        public int PartId { get; set; }

        [StringLength(Part.PartNameMaxLength, MinimumLength = Part.PartNameMinLength)]
        public string PartName { get; set; } = null!;

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }       
        public string? Description { get; set; }
    }
}
