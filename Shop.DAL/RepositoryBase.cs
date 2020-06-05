using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Shop.DAL
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected ShopDbContext ShopDbContext { get; set; }

        public RepositoryBase(ShopDbContext shopDbContext)
        {
            this.ShopDbContext = shopDbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return ShopDbContext.Set<T>().ToList();
        }

        public void Create(T entity)
        {
            this.ShopDbContext.Set<T>().Add(entity);
            ShopDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            this.ShopDbContext.Set<T>().Update(entity);
            ShopDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            this.ShopDbContext.Set<T>().Remove(entity);
            ShopDbContext.SaveChanges();
        }
        public T GetById(int id)
        {
            var entity = this.ShopDbContext.Set<T>().Find(id);
            ShopDbContext.Entry(entity).State = EntityState.Detached;
     
            return entity;
        }
    }
}
