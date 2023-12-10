namespace BicycleApp.Services.Models.Order.OrderUser.Contracts
{
   
    public interface IOrderProgretionDto
    {
        public int OrderId { get; set; }
        public string? SerialNumber { get; set; } 
        public string DateCreated { get; set; } 
        public ICollection<OrderStateDto> OrderStates { get; set; } 
    }
}
