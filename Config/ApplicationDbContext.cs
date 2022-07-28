using HoPro.net.Model;
using Microsoft.EntityFrameworkCore;


namespace HoPro.net.Config
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Access_area> access_areas { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Consumption> consumptions  { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Localhost;Initial Catalog=HoProNet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
