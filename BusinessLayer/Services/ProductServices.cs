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
    }
}
