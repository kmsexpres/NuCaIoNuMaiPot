using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NuCaIoMaSinucid.Data.Entities.NewFolder
{
    public interface IRepository <T> where T : class
    {
        // in caz ca te uiti pe aici teo nu intreba

        T GetById(int ID);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
    }
}
