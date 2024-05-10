using RazaBookingSystem.Data.Enum;

namespace RazaBookingSystem.Data
{
    public class BookingDetail : BaseEntity
    {
        public int UserID { get; set; }
        public int BookingID { get; set; }
        public int HubID { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly TimeStart{ get; set; }
        public TimeOnly TimeEnd { get; set; }
        public Status Status { get; set; }
    }
}
