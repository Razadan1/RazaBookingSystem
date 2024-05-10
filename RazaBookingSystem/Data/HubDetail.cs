using RazaBookingSystem.Data.Enum;

namespace RazaBookingSystem.Data
{
    public class HubDetail
    {
        public int HubId { get; set; }
        public HubName HubName { get; set; }
        public string Location{get; set;}=default!;
        public int Capacity { get; set; }
        public string? Description;
    }
}
