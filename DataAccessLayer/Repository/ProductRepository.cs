using DataAccessLayer.IRepository;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ProductRepository:Repositories<Product> ,IProductRepository
    {
        private readonly CicekPaketiDbContext cicekPaketiDbContext;
        public ProductRepository(CicekPaketiDbContext cicekPaketiDb):base(cicekPaketiDb)
        {
            this.cicekPaketiDbContext=cicekPaketiDb;
        }

    }
}
