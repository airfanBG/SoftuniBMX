namespace BicycleApp.Services.Models.Order.OrderUser.Contracts
{

    public interface IOrderStateDto
    {
        public int PartId { get; set; }
        public string PartType { get; set; }
        public string PartModel { get; set; }
        public string NameOfEmplоyeeProducedThePart { get; set; }
        public bool IsProduced { get; set; }
        public string? SerialNumber { get; set; }
        public string? EmployeeId { get; set; }
        public string? StartDate { get; set; } 
        public string? EndDate { get; set; } 
    }
}
