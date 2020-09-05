using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NuCaIoMaSinucid.Data.Entities.NewFolder
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> entities;

        public Repository(DbContext context)
        {
            this.entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            this.entities.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            this.entities.AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return
                this.entities.Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return this.entities.ToList();
        }

        public T GetById(int ID)
        {
            return
                this.entities.Find(ID);
        }

        public void Remove(T entity)
        {
            this.entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            this.entities.RemoveRange(entities);
        }
    }
}
