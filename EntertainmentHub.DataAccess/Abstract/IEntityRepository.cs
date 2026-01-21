using EntertainmentHub.Entities;
using EntertainmentHub.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentHub.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetProductions(Expression<Func<T, bool>> filter = null);
        T GetProduction(Expression<Func<T, bool>> filter);
        void AddProduction(T entity);
        void UpdateProduction(T entity);
        void DeleteProduction(T entity);
    }
}
