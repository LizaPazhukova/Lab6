using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public List<Product> Products { get; set; }
    }
}
