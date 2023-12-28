namespace BicycleApp.Services.Models
{
    public class PartQueryDto 
    {
        public int TotalPartsCount { get; set; }
        public IEnumerable<PartDto> Parts { get; set; } = new List<PartDto>();
    }
}
