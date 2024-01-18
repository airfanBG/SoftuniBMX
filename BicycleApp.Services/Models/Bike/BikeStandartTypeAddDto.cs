namespace BicycleApp.Services.Models.Bike
{
    using System.ComponentModel.DataAnnotations;

    public class BikeStandartTypeAddDto
    {
        [Required]
        public string ModelName { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public HashSet<int> Parts { get; set; } = new HashSet<int>();
    }
}
