using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BicycleApp.Services.Models.Supply
{
    public class SuplierDetailsDto : SuplierInfoDto
    {
        [Required]
        public string VATNumber { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public ICollection<PartInStockInfoDto> OrderParts { get; set; } = new List<PartInStockInfoDto>();
    }
}
