using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainObjects;


namespace EFModel
{
    public class SystemContext : DbContext
    {

        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        {
        }

        public DbSet<SystemDefinition> SystemDefinitions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemDefinition>().ToTable("SystemDefinition");
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    var connectionString = configuration.GetConnectionString("AppDb");
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

    }

}
