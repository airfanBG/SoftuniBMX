namespace BicycleApp.Services.Models
{
    using Newtonsoft.Json;

    public class PartShortInfoDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = null!;
    }
}
