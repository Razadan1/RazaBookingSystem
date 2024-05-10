namespace RazaBookingSystem.Data
{
    public class Attendance
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public DateOnly Date {  get; set; }

        public TimeOnly CheckIn;
        public TimeOnly CheckOut;
        public string? Remarks;
    }
}
