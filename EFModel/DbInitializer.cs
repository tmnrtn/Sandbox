using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainObjects;

namespace EFModel
{
    public static class DbInitializer
    {
        public static void Initialize(SystemContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.SystemDefinitions.Any())
            {
                return;   // DB has been seeded
            }

            var systems = new SystemDefinition[]
            {
            new SystemDefinition{Name="TestDef"},

            };
            foreach (SystemDefinition s in systems)
            {
                context.SystemDefinitions.Add(s);
            }
            context.SaveChanges();

        }
    }
}
