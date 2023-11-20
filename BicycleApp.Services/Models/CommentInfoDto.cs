namespace BicycleApp.Services.Models
{
    public class CommentInfoDto
    {
        public int Id { get; set; }

        public int PartId { get; set; }

        public string? PartName { get; set; }

        public string? ClientId { get; set; }

        public string? ClientFullName { get; set; }

        public string? ClientImageUrl { get; set; }

        public string? CommentDescription { get; set;}

        public string? DateCreated { get; set; }
    }
}
