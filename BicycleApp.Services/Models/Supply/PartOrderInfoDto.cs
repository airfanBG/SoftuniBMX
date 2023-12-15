namespace BicycleApp.Services.Models.Supply
{
    public class PartOrderInfoDto
    {
        public int Id { get; set; }

        public string PartName { get; set; } = null!;

        public string SuplierName { get; set; } = null!;

        public double Quantity { get; set; }

    }
}
