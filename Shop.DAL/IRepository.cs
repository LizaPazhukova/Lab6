using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.DAL
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(int id);
    }
}
