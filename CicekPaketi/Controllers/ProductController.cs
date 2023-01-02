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

        public IActionResult ProductList()
        {

            return View(productServices.GetProducts());
        }

        public IActionResult Delete(int id)
        {
            if(productServices.removeproduct(id))
            {
                return RedirectToAction("ProductList");
            }

            return RedirectToAction("ProductList");
        }

        public IActionResult Update(int id)
        {
            return View(productServices.GetProduct(id));
        }
        [HttpPost]
        public IActionResult Update(ProductVM model)
        {
           if(productServices.Update(model))
            {
                return RedirectToAction("ProductList");
            }
            return RedirectToAction("ProductList");
        }
    }
}
