namespace BicycleApp.Services.Models.Order.OrderUser.Contracts
{
    public interface IOrderPartsEmplyee : IOrder
    {
        public int OrderQuantity { get; set; }
        public ICollection<IOrderPartDto> OrderParts { get; set; }
    }
}
