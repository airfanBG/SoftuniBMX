namespace BicycleApp.Services.Models.Order
{
    public class RemanufacturingPartEmployeeInfoDto
    {
        public string EmployeeName { get; set; } = null!;
        public string PartName { get; set; } = null!;
        public string? Description { get; set; } 
        public string SerialNumber { get; set; } = null!;
    }
}
