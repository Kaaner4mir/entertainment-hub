using EntertainmentHub.DataAccess.Abstract;
using EntertainmentHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.DataAccess.Concrete.EntityFramework
{
    public class EFProductionDal:IProductionDal
    {
        public List<Production> GetProductions()
        {
            using (EntertainmentHubContext context = new EntertainmentHubContext())
            {
                return context.Productions.ToList();
            }
        }

        public Production GetProduction(int id)
        {
            using (EntertainmentHubContext context = new EntertainmentHubContext())
            {
                return context.Productions.SingleOrDefault(x => x.ProductionID == id);
            }
        }

        public void AddProduction(Production production)
        {
            using (EntertainmentHubContext context = new EntertainmentHubContext())
            {
                context.Productions.Add(production);
                context.SaveChanges();
            }
        }

        public void UpdateProduction(Production production)
        {

        }

        public void DeleteProduction(Production production)
        {

        }
    }
}
