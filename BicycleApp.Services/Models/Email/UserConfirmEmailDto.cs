namespace BicycleApp.Services.Models.Email
{
    public class UserConfirmEmailDto
    {
        public string Id { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string Code { get; set; } = null!;
    }
}