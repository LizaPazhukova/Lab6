using Shop.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logic.Interfaces
{
    public interface IOrderService
    {
        OrderDTO GetById(int id);
        IEnumerable<OrderDTO> GetAll();
        void Add(OrderDTO order);
        void Update(OrderDTO order);
        void Remove(int id);
    }
}
