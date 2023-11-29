namespace BicycleApp.Services.Models.Order.OrderUser.Contracts
{
    public interface IUserOrderDto
    {
        public string ClientId { get; set; }
        public string? Description { get; set; }
        public int OrderQuantity { get; set; }
        public ICollection<OrderPartIdDto> OrderParts { get; set; }
        public int VATId { get; set; }
    }
}
