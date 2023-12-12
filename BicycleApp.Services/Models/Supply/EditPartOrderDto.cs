using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BicycleApp.Services.Models.Supply
{
    public class EditPartOrderDto : CreatePartOrderDto
    {
        [Required]
        public int Id { get; set; }
    }
}
