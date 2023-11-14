namespace BicycleApp.Services.Models.Order
{    
    public class OrderInfoDto
    {
        public int OrderId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public ICollection<OrderPartDto> OrderParts { get; set; } = new List<OrderPartDto>();
    }
}
