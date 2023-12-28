namespace BicycleApp.Services.Models.Order.OrderUser
{
    public class OrderClientShortInfo
    {
        public int OrderId { get; set; }

        public string SerialNumber { get; set; } = null!;

        public string OrderDate { get; set; } = null!;

        public decimal Amount { get; set; }

        public List<PartShortInfoDto> Parts { get; set; } = new List<PartShortInfoDto>();

    }
}
