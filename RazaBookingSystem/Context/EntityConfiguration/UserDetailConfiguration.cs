using RazaBookingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RazaBookingSystem.Context.EntityConfiguration
{
    internal sealed class UserDetailConfiguration : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.Property(a => a.UserName).IsRequired();
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.FirstName).IsRequired();
            builder.Property(a => a.LastName).IsRequired();
            builder.HasKey(c => new { c.UserId, c.AttendanceId });
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.Role).IsRequired();
        }
     }
}
