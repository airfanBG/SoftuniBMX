namespace BicycleApp.Services.Models
{
    public class IndexPageDto
    {  
        public List<BikeStandartTypeDto> DefaultBikes { get; set; } = new List<BikeStandartTypeDto>();

        public List<CommentInfoDto> Comments { get; set; } = new List<CommentInfoDto> { };
    }
}
