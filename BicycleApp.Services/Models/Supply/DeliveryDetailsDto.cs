namespace BicycleApp.Services.Models.Supply
{
    public class DeliveryDetailsDto : DeliveryInfoDto
    {
        public int PartId { get; set; }

        public double QuantityDelivered { get; set; }

        public string? Note { get; set; }

        public int SuplierId { get; set; }
    }
}
