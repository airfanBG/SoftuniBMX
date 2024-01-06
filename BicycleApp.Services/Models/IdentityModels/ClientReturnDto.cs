namespace BicycleApp.Services.Models.IdentityModels
{
    using System.Text.Json.Serialization;

    public class ClientReturnDto
    {
        public string? ClientId { get; set; }

        public string? ClientFullName { get; set; }

        public string? Role { get; set; }

        public string? Token { get; set; }

        public decimal? Balance { get; set; }

        public bool Result { get; set; }

        [JsonPropertyName("imageUrl")]
        public string? Image { get; set; }

        public bool IsAnyOrderReady { get; set; }
    }
}
