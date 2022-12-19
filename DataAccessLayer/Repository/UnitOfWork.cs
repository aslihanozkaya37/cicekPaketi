using DataAccessLayer.IRepository;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly CicekPaketiDbContext cicekPaketiDb;

        public UnitOfWork(CicekPaketiDbContext cicekPaketiDb)
        {
            this.cicekPaketiDb =  cicekPaketiDb;
            BasketRepository = new BasketRepository(cicekPaketiDb);
            UserRepository = new UserRepository(cicekPaketiDb);
            ProductRepository = new ProductRepository(cicekPaketiDb);
        }
        public IBasketRepository BasketRepository { get; set; }

        public IProductRepository ProductRepository { get; set; }

        public IUserRepository UserRepository { get; set; }

        public bool SaveChanges()
        {
            return 0 < cicekPaketiDb.SaveChanges();
        }
    }

}
