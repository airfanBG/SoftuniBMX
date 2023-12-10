namespace BicycleApp.Services.Models.Image
{
    using Microsoft.AspNetCore.Http;

    public class UserImageDto
    {
        public string Id { get; set; } = null!;
        public string? Role { get; set; }
        public IFormFile ImageToSave { get; set; } = null!;
    }
}
