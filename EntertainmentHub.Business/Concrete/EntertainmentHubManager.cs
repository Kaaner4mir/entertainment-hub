using EntertainmentHub.DataAccess.Concrete;
using EntertainmentHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.Business.Concrete
{
    public class EntertainmentHubManager
    {
        ProductionDal _productionDal= new ProductionDal();

        public List<Production> GetAllProductions()
        {
            return _productionDal.GetProductions();
        }
    }
}
