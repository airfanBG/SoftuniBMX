namespace BicycleApp.Services.Models.Order.OrderUser
{
    using BicycleApp.Services.Models.Order.OrderUser.Contracts;

    public class OrderStateDto : IOrderStateDto
    {
        public int PartId { get; set; }
        public string PartType { get; set; } = null!;
        public string PartModel { get; set; } = null!;
        public string NameOfEmplоyeeProducedThePart { get; set; } = null!;
        public bool IsProduced { get; set; }
        public string? SerialNumber { get; set; }
        public string? EmployeeId { get; set; }
        public int? ElementProduceTimeInMinutes { get; set; }
        public  string? Description { get; set; }
    }
}