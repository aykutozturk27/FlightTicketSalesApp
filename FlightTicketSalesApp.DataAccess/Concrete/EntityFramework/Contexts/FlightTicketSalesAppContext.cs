using FlightTicketSalesApp.Core.Utilities.Configuration;
using FlightTicketSalesApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FlightTicketSalesApp.DataAccess.Concrete.EntityFramework.Contexts
{
    public class FlightTicketSalesAppContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CoreConfig.GetConnectionString("Default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
