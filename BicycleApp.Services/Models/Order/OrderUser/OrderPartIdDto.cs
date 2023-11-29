namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public class OrderPartIdDto : IOrderPartIdDto
    {
        public int PartId { get; set; }
    }
}