namespace BicycleApp.Services.Models.Order
{
    using BicycleApp.Services.Models.Order.Contracts;
    using System.Collections.Generic;

    public class UserOrderDto : IUserOrderDto
    {
        public UserOrderDto()
        {
            this.OrderParts = new List<IOrderPartDto>();
        }

        public string ClientId { get; set; } = null!;
        public string? Description { get; set; }
        public int OrderQuantity { get; set; }
        public ICollection<IOrderPartDto> OrderParts { get; set; }
        public int VATId { get; set; }
        public int StatusId { get; set; }
    }
}
