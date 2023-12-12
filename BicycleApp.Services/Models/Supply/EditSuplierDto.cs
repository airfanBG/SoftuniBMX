using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BicycleApp.Services.Models.Supply
{
    public class EditSuplierDto: CreateSuplierDto
    {
        [Required]
        public int Id { get; set; }
    }
}
