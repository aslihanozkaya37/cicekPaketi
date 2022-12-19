using DataAccessLayer.IRepository;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class UserRepository:Repositories<User>,IUserRepository
    {
        private readonly CicekPaketiDbContext cicekPaketiDbContext;
        public UserRepository(CicekPaketiDbContext cicekPaketiDb):base(cicekPaketiDb)
        {
            this.cicekPaketiDbContext = cicekPaketiDb;
        }
    }
}
