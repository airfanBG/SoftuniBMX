namespace BicycleApp.Services.Models.Order.OrderManager
{
    public class OrderPartInfoDto
    {
        public int PartId { get; set; }
        public string? Description { get; set; }
        public string? OemNumber { get; set; }
        public string? CategoryName { get; set; }
        public string PartName { get; set; } = null!;
        public int PartQuantity { get; set; }
        public double PartQunatityInStock { get; set; }
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public bool IsComplete { get; set; }
    }
}
