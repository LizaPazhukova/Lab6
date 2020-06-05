using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Logic.DTO;
using Shop.Logic.Interfaces;


namespace Task6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;

        public OrdersController(IOrderService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<OrderDTO> GetAllOrders()
        {
            return _orderService.GetAll();
        }
        [HttpPost]
        public ActionResult AddOrder(OrderDTO order)
        {
            if(order == null)
            {
                return BadRequest();
            }

            _orderService.Add(order);
            return Ok();
        }
        [HttpGet]
        [Route("{id}")]
        public OrderDTO GetOrderById(int id)
        {
            return _orderService.GetById(id);
        }
        [HttpGet]
        [Route("{id}/products")]
        public IEnumerable<ProductDTO> GetProductsByOrder(int id)
        {
            return _productService.GetAll().Where(x => x.OrderId == id);
        }
        [HttpPut]
        [Route("{id}/products")]
        public ActionResult AddProductToOrder(int id, ProductDTO product)
        {
           var order =  _orderService.GetById(id);

            if (order == null)
            {
                return NotFound();
            }

            order.Products.Add(product);
           _orderService.Update(order);
            return Ok();

        }
    }
}