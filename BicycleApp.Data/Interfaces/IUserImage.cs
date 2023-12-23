namespace BicycleApp.Data.Interfaces
{
    public interface IUserImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; } 
        public string ImageUrl { get; set; }
        public string UserId { get; set; } 
    }
}
