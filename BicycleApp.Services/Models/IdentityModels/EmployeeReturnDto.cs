namespace BicycleApp.Services.Models.IdentityModels
{
    using System.Text.Json.Serialization;

    public class EmployeeReturnDto
    {
        public string? EmployeeId { get; set; }

        public string? EmployeeFullName { get; set; }

        public string? Role { get; set; }

        public string? Token { get; set; }

        [JsonPropertyName("imageUrl")]
        public string? Image { get; set; }

        public bool Result { get; set; }
        public EmployeeSalaryInfoDto? EmployeeSalaryInfo { get; set; }
    }
}
