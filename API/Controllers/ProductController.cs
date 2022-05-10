using BLL.Service;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {


            return _productService.GetAll();


        }

        [HttpPost]
        public OkResult CreateProduct(Product Data)
        {


            _productService.Add(Data);
            return Ok();


        }

        [HttpPost]
        public OkResult DeleteProduct(Product Data)
        {


            _productService.Delete(Data);
            return Ok();


        }
    }
}
