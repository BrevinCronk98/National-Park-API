using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace NationalParkAPI.Models
{
    public class ParkAPIContextFactory : IDesignTimeDbContextFactory<ParkAPIContext>
    {


        ParkAPIContext IDesignTimeDbContextFactory<ParkAPIContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ParkAPIContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new ParkAPIContext(builder.Options);
        }
    }
}
