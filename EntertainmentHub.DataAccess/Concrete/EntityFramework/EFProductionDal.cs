using EntertainmentHub.DataAccess.Abstract;
using EntertainmentHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.DataAccess.Concrete.EntityFramework
{
    public class EFProductionDal:EFEntityRepositoryBase<Production, EntertainmentHubContext>, IProductionDal
    {
        
    }
}
