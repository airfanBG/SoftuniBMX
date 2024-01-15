namespace BicycleApp.Services.Models.IdentityModels
{
    using System.Text.Json.Serialization;

    public class ClientInfoDto
    {
        public string? Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string? DelivaryAddress { get; set; }

        public string? Town { get; set; }

        public string? IBAN { get; set; }

        public decimal Balance { get; set; }

        [JsonPropertyName("imageUrl")]
        public string? Image { get; set; }
    }
}
