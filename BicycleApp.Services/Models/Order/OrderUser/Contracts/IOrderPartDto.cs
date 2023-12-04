namespace BicycleApp.Services.Models.Order.OrderUser.Contracts
{
    public interface IOrderPartDto
    {
        public string PartName { get; set; }
        public decimal PartPrice { get; set; }
        public int  PartQuantity { get; set; }
        public int  PartId { get; set; }

    }
}
