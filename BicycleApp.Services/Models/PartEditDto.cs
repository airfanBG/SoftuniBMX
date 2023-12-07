namespace BicycleApp.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PartEditDto : PartAddDto
    {
        [Required]
        public int Id { get; set; }
    }
}
