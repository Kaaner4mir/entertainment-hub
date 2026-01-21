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
        public DbSet<Production> Productions { get; set; }
    }
}
