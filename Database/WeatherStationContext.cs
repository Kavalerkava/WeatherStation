using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class WeatherStationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Sensor> Sensors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WeatherStation;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
                .UseSeeding((context, _) =>


                {
                    var users = context.Set<User>().FirstOrDefault();

                    if (users == null)
                    {
                        var userFaker = new Faker<User>();
                        userFaker.RuleFor(x => x.Name, f => f.Name.FullName());
                        var usersToAdd = userFaker.Generate(1000);


                        context.AddRange(usersToAdd);
                        context.SaveChanges();
                    }
                });
        }
    }
}