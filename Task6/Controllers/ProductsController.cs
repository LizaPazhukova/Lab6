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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetAllProducts()
        {
            return _productService.GetAll(); ;
        }
        [HttpPost]
        public ActionResult AddProduct(ProductDTO product)
        {
            if(product == null)
            {
                return BadRequest();
            }
            _productService.Add(product);
            return Ok();
        }
    }
}