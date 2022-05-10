using Microsoft.EntityFrameworkCore.Design;
using EFModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFModel
{

    public class SystemContextFactory : IDesignTimeDbContextFactory<SystemContext>
    {
        public SystemContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");

            var optionsBuilder = new DbContextOptionsBuilder<SystemContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SystemContext(optionsBuilder.Options);
        }
    }
}
