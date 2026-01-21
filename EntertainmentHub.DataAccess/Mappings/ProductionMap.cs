using EntertainmentHub.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.DataAccess.Mappings
{
    public class ProductionMap : EntityTypeConfiguration<Production>
    {
        public ProductionMap()
        {
            ToTable("Productions");
            HasKey(p => p.ProductionID);

            Property(p=>p.ProductionName).IsRequired().HasMaxLength(50);
            Property(p=>p.ProductionCategory).IsRequired().HasMaxLength(50);
            Property(p => p.ProductionRuntime).IsRequired().HasPrecision(18,2);
            Property(p => p.inTheaters).IsRequired();
            Property(p=>p.ProductionYear).IsRequired();
            Property(p=>p.DirectorID).IsRequired();
        }
    }
}
