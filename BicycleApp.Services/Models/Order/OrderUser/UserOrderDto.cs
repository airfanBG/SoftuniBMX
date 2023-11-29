namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;
    using System.Collections.Generic;

    public class UserOrderDto : IUserOrderDto
    {
        public UserOrderDto()
        {
            OrderParts = new List<OrderPartIdDto>();
        }

        public string ClientId { get; set; } = null!;
        public string? Description { get; set; }
        public int OrderQuantity { get; set; }
        public int VATId { get; set; }
        public ICollection<OrderPartIdDto> OrderParts { get; set; }
    }
}
