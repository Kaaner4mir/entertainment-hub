using EntertainmentHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.Business.Abstract
{
    public interface IProductionService
    {
        List<Production> GetAllProductions();
        List<Production> GetProductionByName(string productionName);
        List<Production> GetProductionByCategory(string productionCategory);
        List<Production> GetProductions(string productionName, string productionCategory);
        void AddProduction(Production production);
        void UpdateProduction(Production production);
        void DeleteProduction(Production production);
    }
}
