using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IUnitOfWork
    {
        IBasketRepository BasketRepository { get; }
        IProductRepository ProductRepository { get; }
        IUserRepository UserRepository { get; }
        bool SaveChanges();
    }
}
