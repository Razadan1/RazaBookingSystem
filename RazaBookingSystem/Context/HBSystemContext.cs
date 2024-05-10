using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;
using RazaBookingSystem.Data;

namespace RazaBookingSystem.Context
{
    public class HBSystemContext(DbContextOptions<HBSystemContext> options) : IdentityDbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<UserDetail> userDetails { get; set; }
        public DbSet<Attendance> attendances { get; set; }
        public DbSet<BookingDetail> bookings { get; set; }
        public DbSet<HubDetail> hubDetails { get; set; }
    }
}
