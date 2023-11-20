namespace BicycleApp.Services.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;
    using Newtonsoft.Json;

    public class ClientLoginDto
    {
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; } = null!;

        [Required]
        [JsonProperty("password")]
        public string Password { get; set; } = null!;
    }
}
