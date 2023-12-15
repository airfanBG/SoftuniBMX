namespace BicycleApp.Services.Models.Rating.Contracts
{    
    public interface IRatingDto
    {
        public string ClientId { get; set; }
        public int PartId { get; set; }
        public int Rating { get; set; }
    }
}
