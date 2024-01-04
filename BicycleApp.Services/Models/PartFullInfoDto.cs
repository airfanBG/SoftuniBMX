namespace BicycleApp.Services.Models
{
    public class PartFullInfoDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Intend { get; set; } = null!;
        public string OEMNumber { get; set; } = null!;
        public int Type { get; set; }
        public string Category { get; set; } = null!;
        public List<string> Images { get; set; } = new List<string>();
        public decimal SalePrice { get; set; }

        public static implicit operator PartFullInfoDto?(Task<PartFullInfoDto>? v)
        {
            throw new NotImplementedException();
        }
    }
}
