namespace BicycleApp.Data.Interfaces
{
    public interface IEntity
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}
