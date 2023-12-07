namespace BicycleApp.Services.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class PartGetDto
    {
        [JsonProperty("partCategories")]
        public List<ObjectDto> PartCategories { get; set; } = new List<ObjectDto>();

        [JsonProperty("vatCategories")]
        public List<ObjectDto> VatCategories { get; set; } = new List<ObjectDto>();
    }
}
