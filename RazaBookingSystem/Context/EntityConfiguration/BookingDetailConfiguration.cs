using RazaBookingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RazaBookingSystem.Context.EntityConfiguration
{
    internal sealed class BookingDetailConfiguration : IEntityTypeConfiguration<BookingDetail>
    {
        public void Configure(EntityTypeBuilder<BookingDetail> builder)
        {
            builder.HasKey(b => b.Id);
            builder.HasKey(b => b.BookingID);
            builder.Property(b => b.HubID).IsRequired();
            builder.Property(b => b.Date).IsRequired();
            builder.Property(b => b.TimeStart).IsRequired();
            builder.Property(b => b.TimeEnd).IsRequired();
        }
    }
}
