namespace BicycleApp.Services.Models.Supply
{
    public class SuplierInfoDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string CategoryName { get; set; } = null!;

        public string ContactName { get; set; } = null!;

        public string? PhoneNumeber { get; set; }

        public string Email { get; set; } = null!;

    }
}
