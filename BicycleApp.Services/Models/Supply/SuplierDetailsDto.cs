using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

using static BicycleApp.Common.EntityValidationConstants.Suplier;

namespace BicycleApp.Services.Models.Supply
{
    public class SuplierDetailsDto
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string VATNumber { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string? PhoneNumeber { get; set; }

        public string Email { get; set; } = null!;

        public string ContactName { get; set; } = null!;
    }
}
