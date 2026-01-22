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
    public class ProductionManager : IProductionService
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

        public List<Production> GetProductionByName(string productionName)
        {
            return _productionDal.GetProductions(p => p.ProductionName.ToLower().Contains(productionName.ToLower()));
        }

        public List<Production> GetProductionByCategory(string productionCategory)
        {
            return _productionDal.GetProductions(p => p.ProductionCategory.ToLower().Contains(productionCategory.ToLower()));
        }

        public List<Production> GetProductions(string productionName, string productionCategory)
        {
            return _productionDal.GetProductions(p =>
                (string.IsNullOrEmpty(productionName) || p.ProductionName.ToLower().Contains(productionName.ToLower())) &&
                (string.IsNullOrEmpty(productionCategory) || p.ProductionCategory.ToLower().Contains(productionCategory.ToLower())));
        }

        public void AddProduction(Production production)
        {
            _productionDal.AddProduction(production);
        }

        public void UpdateProduction(Production production)
        {
            _productionDal.UpdateProduction(production);
        }

        public void DeleteProduction(Production production)
        {
            _productionDal.DeleteProduction(production);
        }
    }
}
