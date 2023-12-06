namespace BicycleApp.Services.Models.Order
{    
    public class RemanufacturingOrderPartDto
    {
        public int OrderId { get; set; }
        public int PartId { get; set; }
        public string? Description { get; set; }
    }
}
