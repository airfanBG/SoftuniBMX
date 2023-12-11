namespace BicycleApp.Services.Models
{
    public class BikeStandartTypeEditDto
    {
        public int Id { get; set; }

        public string? ModelName { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public decimal? Price { get; set; }

        public HashSet<int> Parts { get; set; } = new HashSet<int>();
    }
}
