namespace BicycleApp.Services.Models.Order
{    
    public class OrderProgretionDto
    {
        public int OrderId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string DateCreated { get; set; } = null!;
        public ICollection<OrderStateDto> OrderStates  { get; set; } = new List<OrderStateDto>();
    }
}
