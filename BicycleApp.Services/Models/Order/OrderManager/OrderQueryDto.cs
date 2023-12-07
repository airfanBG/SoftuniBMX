using BicycleApp.Services.Models.Order.OrderManager;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace BicycleApp.Services.Models.Order
{
    public class OrderQueryDto 
    {
        public int TotalOrdersCount { get; set; }
        public IEnumerable<OrderInfoDto> Orders { get; set; } = new List<OrderInfoDto>();
    }
}
