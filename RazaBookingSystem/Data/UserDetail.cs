namespace RazaBookingSystem.Data
{
    public class UserDetail
    {
        public int UserId { get; set; }
        public int AttendanceId { get; set;  }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Role { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
