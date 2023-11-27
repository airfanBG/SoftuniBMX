namespace BicycleApp.Services.Models.IdentityModels
{
    using Newtonsoft.Json;
        
    public class ClientAddressDto
    {
        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("postCode")]
        public string? PostCode { get; set; }

        [JsonProperty("district")]
        public string? District { get; set; }

        [JsonProperty("block")]
        public string? Block { get; set; }

        [JsonProperty("floor")]
        public int? Floor { get; set; }

        [JsonProperty("apartment")]
        public string? Apartment { get; set; }

        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("strNumber")]
        public string? StrNumber { get; set; }
    }
}
