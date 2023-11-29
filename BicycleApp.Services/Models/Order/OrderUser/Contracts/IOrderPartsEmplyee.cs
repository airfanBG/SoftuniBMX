namespace BicycleApp.Services.Models.Order.OrderUser.Contracts
{
    public interface IOrderPartsEmplyee : IOrder
    {
        public ICollection<IOrderPartDto> OrderParts { get; set; }
    }
}
