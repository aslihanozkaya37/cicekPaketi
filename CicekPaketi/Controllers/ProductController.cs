using BusinessLayer.IServices;
using BusinessLayer.ViewModels;
using CicekPaketi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CicekPaketi.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices productServices;
        public ProductController(IProductServices productServices)
        {
            this.productServices = productServices;
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(ProductVM productVm)
        {
           bool response = productServices.addproduct(productVm);
            if (response)
                return RedirectToAction("CreateProduct");
            else
                return View(productVm);
        }
    }
}
