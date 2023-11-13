namespace BicycleApp.Services.Models.Order
{
    using System.ComponentModel.DataAnnotations;

    public class OrderPartDto
    {       
        public int PartId { get; set; }

        [Range(1,int.MaxValue)]
        public int Quantity { get; set; }

        [Range(typeof(decimal), "0.00", "999999.99")]
        public decimal PricePerUnit { get; set; }

        [Range(typeof(decimal), "0.00", "999999.99")]
        public decimal Discount { get; set; }
        public string? Description { get; set; }
    }
}