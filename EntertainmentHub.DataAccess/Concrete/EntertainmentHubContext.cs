using EntertainmentHub.DataAccess.Mappings;
using EntertainmentHub.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.DataAccess.Concrete
{
    public class EntertainmentHubContext: DbContext
    {
        public EntertainmentHubContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EntertainmentHubContext>());
        }

        public DbSet<Production> Productions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductionMap());
        }
    }
}
