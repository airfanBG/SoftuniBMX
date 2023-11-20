namespace BicycleApp.Services.Models
{
    public class BikeStandartTypeDto
    {
        public int Id { get; set; }

        public string? ModelName { get; set; }

        public string? ImageUrl { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }
    }
}
