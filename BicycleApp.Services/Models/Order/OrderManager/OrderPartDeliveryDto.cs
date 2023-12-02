namespace BicycleApp.Services.Models.Order.OrderManager
{
    public class OrderPartDeliveryDto
    {
        public int PartId { get; set; }
        public string Name { get; set; } = null!;
        public string? Note { get; set; } = null!;
        public int NeededQuantity { get; set; }
    }
}
