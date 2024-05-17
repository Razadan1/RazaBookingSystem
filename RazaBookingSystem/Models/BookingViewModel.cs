using System.ComponentModel.DataAnnotations;
using RazaBookingSystem.Data.Enum;

namespace RazaBookingSystem.Models
{
    public class BookingViewModel
    {
        [Required]
        public int HubId { get; set; }

        [Required]
        public HubName HubName { get; set; }

        [Required]
        public string Location { get; set; } = default!;

        [Required]
        public int Capacity { get; set; }

        public string? Description { get; set; }

    }
}
