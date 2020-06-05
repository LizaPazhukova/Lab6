using Microsoft.EntityFrameworkCore;
using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL
{
    public class ShopDbContext: DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData(
        //        new Product[]
        //        {
        //        new Product { Id = 1, Name = "Product1", Price = 25, OrderId = 1, Order = new Order { Id = 1, Cost = 60, Products = new List<Product> { new Product { Id = 1, Name = "Product1", Price = 25 },
        //                                                                          new Product { Id = 2, Name = "Product2", Price = 30 } } }  } ,
        //        //new Product { Id = 2, Name = "Product2", Price = 30, OrderId = 2 },
        //        //new Product { Id = 3, Name = "Product3", Price = 35, OrderId =2 }
        //});
        //    modelBuilder.Entity<Order>().HasData(
        //        new Order[]
        //        {
        //            new Order { Id = 1, Cost = 55, Products = new List<Product> { new Product { Id = 1, Name = "Product1", Price = 25 },
        //                                                                          new Product { Id = 2, Name = "Product2", Price = 30 },
        //            } },
        //            new Order { Id = 2, Cost = 65, Products = new List<Product> {  new Product { Id = 2, Name = "Product2", Price = 30 },
        //                                                                           new Product { Id = 3, Name = "Product3", Price = 35 }
        //            } }
        //        });
        //}
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
            : base(options)
        { 
            Database.EnsureCreated();
        }

    }
}
