using BicycleApp.Services.Models.Part;

namespace BicycleApp.Services.Models.Order.OrderUser
{
    public class OrderClientShortInfo
    {
        public int OrderId { get; set; }

        public string SerialNumber { get; set; } = null!;

        public string OrderDateStart { get; set; } = null!;

        public string? OrderDateFinish { get; set; }

        public decimal Amount { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal UnpaidAmount { get; set; }

        public List<PartShortInfoDto> Parts { get; set; } = new List<PartShortInfoDto>();

    }
}
