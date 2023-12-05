namespace BicycleApp.Services.Models.Supply
{
    public class SupplierInfoDto
    {
        public string SupplierName { get; set; } = null!;

        public string PartCategoryName { get; set; } = null!;

        public string ContactName { get; set; } = null!;

        public string? PhoneNumeber { get; set; }

        public string Email { get; set; } = null!;
    }
}
