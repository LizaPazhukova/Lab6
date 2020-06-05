 using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logic.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int OrderId { get; set; }
    }
}
