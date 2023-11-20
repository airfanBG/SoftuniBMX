namespace BicycleApp.Services.Models.IdentityModels
{
    public class EmployeeReturnDto
    {
        public string? EmployeeId { get; set; }

        public string? EmployeeFullName { get; set; }

        public string? Role { get; set; }

        public string? Token { get; set; }

        public bool Result { get; set; }
    }
}
