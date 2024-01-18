using BicycleApp.Services.Models.Bike;
using BicycleApp.Services.Models.Comment;

namespace BicycleApp.Services.Models.HomePage
{
    public class IndexPageDto
    {
        public List<BikeStandartTypeDto> DefaultBikes { get; set; } = new List<BikeStandartTypeDto>();

        public List<CommentInfoDto> Comments { get; set; } = new List<CommentInfoDto> { };
    }
}
