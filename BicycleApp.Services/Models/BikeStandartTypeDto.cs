namespace BicycleApp.Services.Models
{
    public class BikeStandartTypeDto
    {
        public int Id { get; set; }

        public string? ModelName { get; set; }

        public string? UmageUrl { get; set; }

        public List<PartShortInfoDto> Parts { get; set; } = new List<PartShortInfoDto>();
    }
}
