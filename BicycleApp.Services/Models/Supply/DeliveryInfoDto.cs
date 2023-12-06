namespace BicycleApp.Services.Models.Supply
{
    public class DeliveryInfoDto
    {
        public int Id { get; set; }

        public string PartName { get; set; } = null!;

        public string SupplierName { get; set; } = null!;

        public DateTime DateDelivered { get; set; }
    }
}
