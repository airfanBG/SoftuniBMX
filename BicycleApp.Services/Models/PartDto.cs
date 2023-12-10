namespace BicycleApp.Services.Models
{
    public class PartDto
    {
        public int Id { get; set; }     
        public string Name { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Intend { get; set; } = null!;
        public List<string> ImageUrls { get; set; } = new List<string>();
        public string? OEMNumber { get; set; }
        public int Rating { get; set; }
        public int Type { get; set; }
        public decimal SalePrice { get; set; }
    }
}
