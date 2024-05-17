using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;
using RazaBookingSystem.Data;
using Microsoft.AspNetCore.Identity;


namespace RazaBookingSystem.Context
{
    public class HBSystemContext : IdentityDbContext<IdentityUser>
    {
        public HBSystemContext(DbContextOptions<HBSystemContext> options) : base (options)
        {
        }
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
