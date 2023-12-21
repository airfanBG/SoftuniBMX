using System.Text.Json.Serialization;

namespace BicycleApp.Services.Models
{

    public class PartShortInfoDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;
    }
}
