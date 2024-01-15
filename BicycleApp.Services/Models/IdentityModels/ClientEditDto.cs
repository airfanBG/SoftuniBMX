using BicycleApp.Services.Models.IdentityModels.Contracts;
using System.Text.Json.Serialization;

namespace BicycleApp.Services.Models.IdentityModels
{
    public class ClientEditDto : IBaseClientDto
    {
        [JsonPropertyName("id")]
        public string ClientId { get; set; } = null!;

        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("city")]
        public string? Town { get; set; }

        [JsonPropertyName("iban")]
        public string? IBAN { get; set; }

        [JsonPropertyName("balance")]
        public decimal Balance { get; set; }

        [JsonPropertyName("imageUrl")]
        public string? Image { get; set; }

        [JsonPropertyName("address")]
        public ClientAddressDto DelivaryAddress { get; set; } = null!;
    }
}

