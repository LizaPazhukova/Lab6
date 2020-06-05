using Shop.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logic.Interfaces
{
    public interface IProductService
    {
        ProductDTO GetById(int id);
        IEnumerable<ProductDTO> GetAll();
        void Add(ProductDTO product);
        void Update(ProductDTO product);
        void Remove(int id);

    }
}
