namespace BicycleApp.Services.Models.IdentityModels
{
    public class EmployeeInfoDto
    {
        public string? Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; } = null!;
        public string ImageUrl { get; set; } 
        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }
        public string? Role { get; set; }

        public string? Position { get; set; } = null!;

        public string? DateOfHire { get; set; }

        public string? DateOfLeave { get; set; }

        public string? DateCreated { get; set; }

        public string? DateUpdated { get; set; }

        public string? Department { get; set; }

        public bool IsManeger { get; set; }
    }
}
