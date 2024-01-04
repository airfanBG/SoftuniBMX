namespace BicycleApp.Services.Models.Order.OrderUser
{
    public class OrderDtoInfo
    {

        public string SerialNumber { get; set; } = null!;

        public string? Description { get; set; }

        public string FinalAmount { get; set; }

        public string UnpaidAmount { get; set; }

        public string Status { get; set; } = null!;

        public string DateCreated { get; set; } = null!;

        public string DateFinished { get; set; } = null!;
    }
}
