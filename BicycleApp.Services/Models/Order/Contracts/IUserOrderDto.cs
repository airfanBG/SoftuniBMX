namespace BicycleApp.Services.Models.Order.Contracts
{
    public interface IUserOrderDto
    {
        public string ClientId { get; set; }
        public string? Description { get; set; }
        public int OrderQuantity { get; set; }
        public ICollection<IOrderPartDto> OrderParts { get; set; }
        public int VATId { get; set; }
        public int StatusId { get; set; }
    }
}
