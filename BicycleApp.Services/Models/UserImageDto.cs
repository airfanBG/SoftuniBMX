namespace BicycleApp.Services.Models
{
    using Microsoft.AspNetCore.Http;

    public class UserImageDto
    {
        public string Id { get; set; } = null!;
        public string? Role { get; set; }
        public IFormFile ImageToSave { get; set; } = null!;
    }
}
