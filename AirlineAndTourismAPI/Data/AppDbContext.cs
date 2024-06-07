using AirlineAndTourismAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AirlineAndTourismAPI.Data
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<ActiveFlight> activeFlights { get; set; }
    }
}
