using System.Text.Json.Serialization;

namespace BicycleApp.Services.Models.IdentityModels
{
    public class ClientEditDto
    {
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("phone")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("city")]
        public string? Town { get; set; }

        [JsonPropertyName("address")]
        public ClientAddressDto DelivaryAddress { get; set; } = null!;
    }
}

