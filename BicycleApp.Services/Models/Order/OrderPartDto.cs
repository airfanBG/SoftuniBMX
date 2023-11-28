namespace BicycleApp.Services.Models.Order
{
    using System.ComponentModel.DataAnnotations;
    using static BicycleApp.Common.EntityValidationConstants;

    public class OrderPartDto
    {       
        public int PartId { get; set; }

        [StringLength(Part.PartNameMaxLength, MinimumLength = Part.PartNameMinLength)]
        public string PartName { get; set; } = null!;

        [Range(1,int.MaxValue)]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue)]
        public double QuantityInStock { get; set; }

        [Range(typeof(decimal), "0.00", "999999.99")]
        public decimal PricePerUnit { get; set; }

        [Range(typeof(decimal), "0.00", "999999.99")]
        public decimal Discount { get; set; }
        public string? Description { get; set; }
    }
}