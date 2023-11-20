namespace BicycleApp.Services.Models.Order
{
    public class EmployeePartTaskDto
    {
        public string PartName { get; set; } = null!;

        //Need to know how many parts must be manufactured.
        public int? Quantity { get; set; }
    }
}
