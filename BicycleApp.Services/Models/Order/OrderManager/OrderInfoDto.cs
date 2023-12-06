namespace BicycleApp.Services.Models.Order.OrderManager
{
    public class OrderInfoDto
    {
        public int OrderId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string DateCreated { get; set; } = null!;
        public string DateFinished { get; set; } = null!;
        public ICollection<OrderPartInfoDto> OrderParts { get; set; } = new List<OrderPartInfoDto>();
    }
}
