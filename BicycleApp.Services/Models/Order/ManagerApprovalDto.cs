namespace BicycleApp.Services.Models.Order
{
    public class ManagerApprovalDto
    {
        public string EmployeeId { get; set; } = null!;
        public int OrderId { get; set; }
        public OrderPartDto OrderParts { get; set; } = null!;
    }
}
