namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public class OrderPartDto : IOrderPartDto
    {
        public string PartName { get; set; } = null!;
        public int PartQuantity { get; set; }
        public int PartId { get; set; }
        public decimal PartPrice { get; set; }
        public string? Descrioption { get; set; }
    }
}
