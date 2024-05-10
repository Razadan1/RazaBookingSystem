using RazaBookingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RazaBookingSystem.Context.EntityConfiguration
{
    internal sealed class HubDetailConfiguration : IEntityTypeConfiguration<HubDetail> 
    {
        public void Configure(EntityTypeBuilder<HubDetail> builder)
        {
            builder.HasKey(h => h.HubId);
            builder.Property(h => h.HubName).IsRequired().HasMaxLength(100);
            builder.Property(h => h.Location).IsRequired();
            builder.Property(h => h.Description).IsRequired().HasMaxLength(400);
        }
    }
}
