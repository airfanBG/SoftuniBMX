namespace BicycleApp.Services.Models.Order
{
    using BicycleApp.Services.Models.Order.OrderUser;

    public class UserOrderDto
    {       
        public string ClientId { get; set; } = null!;      
        public int VATId { get; set; }      
        public int StatusId { get; set; }
        public string? Description { get; set; }
        public ICollection<OrderPartDto> OrderParts { get; set; } = new List<OrderPartDto>();

    }
}
