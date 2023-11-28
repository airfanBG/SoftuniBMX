namespace BicycleApp.Services.Models.Order
{
    using BicycleApp.Services.Models.Order.Contracts;

    public class OrderPartDto : IOrderPartDto
    {
        public int PartId { get; set; }
    }
}