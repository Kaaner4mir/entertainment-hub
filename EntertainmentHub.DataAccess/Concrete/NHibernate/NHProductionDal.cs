using EntertainmentHub.DataAccess.Abstract;
using EntertainmentHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.DataAccess.Concrete.NHibernate
{
    public class NHProductionDal : IProductionDal
    {
        public void AddProduction(Production production)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduction(Production production)
        {
            throw new NotImplementedException();
        }

        public Production GetProduction(int id)
        {
            throw new NotImplementedException();
        }

        public List<Production> GetProductions()
        {
            List<Production> productions = new List<Production>
            {
                new Production{ProductionID=1, ProductionName="Inception", ProductionCategory="Sci-Fi", ProductionRuntime=2.8M, inTheaters=0, ProductionYear=2010, DirectorID=1},
                new Production{ProductionID=2, ProductionName="The Dark Knight", ProductionCategory="Action", ProductionRuntime=2.5M, inTheaters=0, ProductionYear=2008, DirectorID=1},
                new Production{ProductionID=3, ProductionName="Interstellar", ProductionCategory="Sci-Fi", ProductionRuntime=2.9M, inTheaters=0, ProductionYear=2014, DirectorID=1},
                new Production{ProductionID=4, ProductionName="Pulp Fiction", ProductionCategory="Crime", ProductionRuntime=2.5M, inTheaters=0, ProductionYear=1994, DirectorID=2},
                new Production{ProductionID=5, ProductionName="Django Unchained", ProductionCategory="Western", ProductionRuntime=2.8M, inTheaters=0, ProductionYear=2012, DirectorID=2}
            };

            return productions;
        }

        public void UpdateProduction(Production production)
        {
            throw new NotImplementedException();
        }
    }
}
