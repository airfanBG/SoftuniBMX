using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BicycleApp.Services.Models.Supply
{
    public class EditDelivedryDto: CreateDelivedryDto
    {
        [Required]
        public int Id { get; set; }
    }
}
