using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainObjects;
using Microsoft.Extensions.Configuration;

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



    }

}
