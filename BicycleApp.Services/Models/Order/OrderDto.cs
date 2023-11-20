namespace BicycleApp.Services.Models.Order
{
    public class OrderDto
    {       
        public string ClientId { get; set; } = null!;      
        public int VATId { get; set; }      
        public int StatusId { get; set; }
        public string? Description { get; set; }
        public ICollection<OrderPartDto> OrderParts { get; set; } = new List<OrderPartDto>();

    }
}
