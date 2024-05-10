namespace RazaBookingSystem.Data
{
    public abstract class BaseEntity
    {
        public  int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
