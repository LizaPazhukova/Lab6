using AutoMapper;
using Shop.DAL.Models;
using Shop.DAL.Repositories;
using Shop.Logic.DTO;
using Shop.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Logic.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _rep;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository rep)
        {
            _rep = rep;
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Order, OrderDTO>();
                cfg.CreateMap<OrderDTO, Order>();
                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<ProductDTO, Product>();
            });
            _mapper = new Mapper(config);
        }
        public OrderDTO GetById(int id)
        {
            return _mapper.Map<Order, OrderDTO>(_rep.GetById(id));
        }
        public void Add(OrderDTO orderDto)
        {
            var order = new Order()
            {
                Id = orderDto.Id,
                Cost = orderDto.Cost,
                Products = _mapper.Map<IEnumerable<ProductDTO>, List<Product>>(orderDto.Products)
            };

            _rep.Create(order);

        }

        public IEnumerable<OrderDTO> GetAll()
        {

            return _mapper.Map<IEnumerable<Order>, List<OrderDTO>>(_rep.GetAll());
        }

        public void Remove(int id)
        {
            _rep.Delete(id);
        }

        public void Update(OrderDTO newOrderDto)
        {
            var newOrder = _mapper.Map<OrderDTO, Order>(newOrderDto);
            _rep.Update(newOrder);
        }
    }
}
