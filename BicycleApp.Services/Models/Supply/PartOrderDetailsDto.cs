using System.ComponentModel.DataAnnotations;

namespace BicycleApp.Services.Models.Supply
{
    public class PartOrderDetailsDto:PartOrderInfoDto
    {
        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public string? Note { get; set; }
    }
}
