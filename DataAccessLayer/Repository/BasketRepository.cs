using DataAccessLayer.IRepository;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BasketRepository:Repositories<Basket> ,IBasketRepository
    {
        private readonly CicekPaketiDbContext cicekPaketiDbContext;
        public BasketRepository(CicekPaketiDbContext cicekPaketiDb):base(cicekPaketiDb)
        {
            this.cicekPaketiDbContext = cicekPaketiDb;
        }
    }
}
