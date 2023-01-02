using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IServices
{
    public interface IProductServices
    {
        IEnumerable<ProductVM> GetProducts();
        bool addproduct(ProductVM model);
        bool removeproduct(int id);
        ProductVM GetProduct(int id);
        bool Update(ProductVM productVM);
    }
}
