namespace Flight_Manager.Data
{
    using Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;    
    using Microsoft.AspNetCore.Identity;

    public class FlightDbContext : IdentityDbContext<FlightUser, IdentityRole, string>
    {
        public DbSet<Flight> Flights { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<FlightType> FlightTypes { get; set; }

        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(options)
        {
        }

    }
}
