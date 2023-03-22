using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using UserRegistrationForm.Configuration;

namespace UserRegistrationForm.Factory
{
    public class DbContextFactory:IDesignTimeDbContextFactory<DbContextModel>
    {
        public DbContextModel CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
            .AddJsonFile("appsettings.Development.json")
            .AddEnvironmentVariables()
            .Build();
            var optionsBuilder = new DbContextOptionsBuilder<DbContextModel>();
           // var serverVersion = new sqlserververs(new Version(8, 0, 28));
            optionsBuilder.UseSqlServer(config.GetConnectionString("ContactAPIConnectionString"));
            return new DbContextModel(optionsBuilder.Options);
        }
    }
}
