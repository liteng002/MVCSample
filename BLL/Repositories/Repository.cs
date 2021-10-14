using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class Repository<T> where T : BaseEntity, new()
    {

        protected SqlDbContext context;
        protected DbSet<T> dbset;
        public Repository(SqlDbContext context)
        {
            this.context = context;
            dbset = context.Set<T>();

        }
        public int Save(T entity)
        {
            dbset.Add(entity);
            context.SaveChanges();
            return entity.Id;
            // throw new NotImplementedException();
        }
        public void Remove(T entity)
        {

        }
        public T LoadProxy(int id)
        {
            T entity = new T { Id = id };
            dbset.Attach(entity);
            return entity;
        }
    }
}
