using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logic.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}
