namespace BicycleApp.Services.Models.IdentityModels
{
    public class ClientReturnDto
    {
        public string? ClientId { get; set; }

        public string? ClientFullName { get; set; }

        public string? Role { get; set; }

        public string? Token { get; set; }

        public decimal? Balance { get; set; }

        public bool Result { get; set; }

        public string? Image { get; set; } 
    }
}
