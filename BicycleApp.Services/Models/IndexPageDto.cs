namespace BicycleApp.Services.Models
{
    public class IndexPageDto
    {
        public string? UserId { get; set; }
        public string? UserFullName { get; set; }

        public List<BikeStandartTypeDto> DefaultBikes { get; set; } = new List<BikeStandartTypeDto>();

        public List<CommentInfoDto> Comments { get; set; } = new List<CommentInfoDto> { };
    }
}
