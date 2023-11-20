namespace BicycleApp.Services.Models.IdentityModels
{
    using System.ComponentModel.DataAnnotations;

    using Newtonsoft.Json;

    public class ClientPasswordChangeDto
    {
        [Required]
        [JsonProperty("oldPassword")]
        public string OldPassword { get; set; } = null!;

        [Required]
        [JsonProperty("newPassword")]
        public string NewPasword { get; set; } = null!;

        [Required]
        [JsonProperty("id")]
        public string ClentId { get; set; } = null!;
    }
}
