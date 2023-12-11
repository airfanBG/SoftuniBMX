using BicycleApp.Services.Models.Order.OrderManager;


namespace BicycleApp.Services.Models.Order
{
    public class OrderQueryDto 
    {
        public int TotalOrdersCount { get; set; }
        public IEnumerable<OrderInfoDto> Orders { get; set; } = new List<OrderInfoDto>();
    }
}
