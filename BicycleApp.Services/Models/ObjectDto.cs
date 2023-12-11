namespace BicycleApp.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    public class ObjectDto
    {
        [Required]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Required]
        [JsonProperty("name")]
        public string Name { get; set; } = null!;
    }
}
