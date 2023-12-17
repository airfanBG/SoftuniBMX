namespace BicycleApp.Services.Models.IdentityModels
{
    using System.Text.Json.Serialization;

    public class ClientAddressDto
    {
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("postCode")]
        public string? PostCode { get; set; }

        [JsonPropertyName("district")]
        public string? District { get; set; }

        [JsonPropertyName("block")]
        public string? Block { get; set; }

        [JsonPropertyName("floor")]
        public int? Floor { get; set; }

        [JsonPropertyName("apartment")]
        public string? Apartment { get; set; }

        [JsonPropertyName("street")]
        public string? Street { get; set; }

        [JsonPropertyName("strNumber")]
        public string? StrNumber { get; set; }
    }
}
