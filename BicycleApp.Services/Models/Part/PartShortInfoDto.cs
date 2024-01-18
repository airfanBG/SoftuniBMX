namespace BicycleApp.Services.Models.Part
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
