using BusinessLayer.IServices;
using BusinessLayer.ViewModels;
using DataAccessLayer.IRepository;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IUnitOfWork unitOfWork;

        public ProductServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public bool addproduct(ProductVM model)
        {
            Product p = new Product();
            p.ProductName= model.ProductName;
            p.Image1 = model.Image1;
            p.Image2 = model.Image2;
            p.Image3 = model.Image3;
            p.Price = model.Price;
            p.Quantity = model.Quantity;
            unitOfWork.ProductRepository.Add(p);
            return unitOfWork.SaveChanges();
        }

        public ProductVM GetProduct(int id)
        {
            Product p = unitOfWork.ProductRepository.GetFirstOrDefault(x => x.id == id);
            ProductVM model = new ProductVM();
            model.ProductName = p.ProductName;
            model.Image1 = p.Image1;
            model.Image2 = p.Image2;
            model.Image3 = p.Image3;
            model.Price = p.Price;
            model.Quantity = p.Quantity;
            model.Id = p.id;
            return model;
        }

        public IEnumerable<ProductVM> GetProducts()
        {
            List<ProductVM> products = new List<ProductVM>();
            foreach (Product model in unitOfWork.ProductRepository.GetAll())
            {
                ProductVM product = new ProductVM();
                product.Id = model.id;
                product.ProductName = model.ProductName;
                product.Image1 = model.Image1;
                product.Image2 = model.Image2;
                product.Image3 = model.Image3;
                product.Price = model.Price;
                product.Quantity = model.Quantity;
               
                products.Add(product);
            }
            
            return products;
        }

        public bool removeproduct(int id)
        {
            unitOfWork.ProductRepository.Delete(id);
            return unitOfWork.SaveChanges();
        }

        public bool Update(ProductVM productVM)
        {
            Product product = new Product();
            product.ProductName = productVM.ProductName;
            product.id = productVM.Id;
            product.Image1 = productVM.Image1;
            product.Image2=productVM.Image2;
            product.Image3=productVM.Image3;
            product.Price=productVM.Price;
            product.Quantity=productVM.Quantity;
            unitOfWork.ProductRepository.Update(product);
            return unitOfWork.SaveChanges();


        }
    }
}
