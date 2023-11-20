namespace BicycleApp.Services.Models.Order
{    
    public class OrderProgretionDto
    {
        public int OrderId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string DateCreated { get; set; } = null!;
        ICollection<OrderStateDto> OrderStates = new  List<OrderStateDto>();
    }
}
