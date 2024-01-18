namespace BicycleApp.Services.Models.Comment
{
    using Newtonsoft.Json;

    public class CommentEditDto : CommentAddDto
    {
        [JsonProperty("commentId")]
        public int Id { get; set; }
    }
}
