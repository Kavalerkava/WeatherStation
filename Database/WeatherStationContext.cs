using Microsoft.EntityFrameworkCore;


namespace Database
{
    public class WeatherStationContext : DbContext
    {
      
      DbSet<User>  Users { get; set; }
      DbSet<Sensor> Sensor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }
    }

}

