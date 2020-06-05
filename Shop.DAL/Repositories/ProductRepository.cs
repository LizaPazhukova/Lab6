using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ShopDbContext shopDbContext)
            : base(shopDbContext)
        { }
    }
}
