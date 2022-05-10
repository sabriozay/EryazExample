using BLL.Service;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetAllProduct()
        {
            List<Product>Result = _productService.GetAll();

            return Json(Result);
        }

        [HttpPost]
        public JsonResult DeleteProduct(Product product)
        {
            
            _productService.Delete(product);

            return Json(product);
        }

        [HttpPost]
        public JsonResult AddProduct(Product product)
        {

            _productService.Add(product);

            return Json(product);
        }

        [HttpPost]
        public JsonResult UpdateProduct(Product product)
        {

            _productService.Update(product);

            return Json(product);
        }
    }
}
