using AutoMapper;
using Shop.DAL;
using Shop.DAL.Models;
using Shop.DAL.Repositories;
using Shop.Logic.DTO;
using Shop.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logic.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _rep;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository rep)
        {
            _rep = rep;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>());
            _mapper = new Mapper(config);
        }
        public ProductDTO GetById(int id)
        {
            return _mapper.Map<Product, ProductDTO>(_rep.GetById(id));
        }
        public void Add(ProductDTO productDto)
        {
            var product = new Product()
            {
                Name = productDto.Name,
                Price = productDto.Price,
                OrderId = productDto.OrderId
            };

            _rep.Create(product);

        }

        public IEnumerable<ProductDTO> GetAll()
        {
    
            return _mapper.Map<IEnumerable<Product>, List<ProductDTO>>(_rep.GetAll());
        }

        public void Remove(int id)
        {
            _rep.Delete(id);
        }

        public void Update(ProductDTO newProductDto)
        {
            var newProduct = _mapper.Map<ProductDTO, Product>(newProductDto);
            _rep.Update(newProduct);
        }
    }
}
