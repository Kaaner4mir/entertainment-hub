using EntertainmentHub.Business.Abstract;
using EntertainmentHub.DataAccess.Abstract;
using EntertainmentHub.DataAccess.Concrete;
using EntertainmentHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.Business.Concrete
{
    public class ProductionManager:IProductionService
    {
        private IProductionDal _productionDal;

        public ProductionManager(IProductionDal productionDal)
        {
            _productionDal = productionDal;
        }

        public List<Production> GetAllProductions()
        {
            return _productionDal.GetProductions();
        }
    }
}
