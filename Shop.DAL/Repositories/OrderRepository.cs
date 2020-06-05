using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ShopDbContext shopDbContext)
            : base(shopDbContext)
        { }
    }
}
