using Microsoft.EntityFrameworkCore;
using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL
{
    public static class ShopDbInitializer
    {
        public static void Initialize(ShopDbContext context) 
        {
            var products = 
                new Product[]
                {
                new Product { Id = 1, Name = "Product1", Price = 25, OrderId = 1, Order = new Order { Id = 1, Cost = 60, Products = new List<Product> { new Product { Id = 1, Name = "Product1", Price = 25 },
                                                                                  new Product { Id = 2, Name = "Product2", Price = 30 },
                    }  } },
                new Product { Id = 2, Name = "Product2", Price = 30, OrderId = 2 },
                new Product { Id = 3, Name = "Product3", Price = 35, OrderId =2 }
        };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

            var orders = 
                new Order[]
                {
                    new Order { Id = 1, Cost = 55, Products = new List<Product> { new Product { Id = 1, Name = "Product1", Price = 25 },
                                                                                  new Product { Id = 2, Name = "Product2", Price = 30 },
                    } },
                    new Order { Id = 2, Cost = 65, Products = new List<Product> {  new Product { Id = 2, Name = "Product2", Price = 30 },
                                                                                   new Product { Id = 3, Name = "Product3", Price = 35 }
                    } }

        };
            foreach (Order o in orders)
            {
                context.Orders.Add(o);
            }
            context.SaveChanges();

        }
    }
}
