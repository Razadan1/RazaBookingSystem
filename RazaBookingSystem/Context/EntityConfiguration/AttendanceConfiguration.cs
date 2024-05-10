using RazaBookingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RazaBookingSystem.Context.EntityConfiguration
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(a => new { a.Id, a.BookingId });
            builder.Property(a => a.CheckIn).IsRequired();
            builder.Property(a => a.CheckOut).IsRequired();
            builder.Property(a => a.Date).IsRequired();
        }
    }
}
