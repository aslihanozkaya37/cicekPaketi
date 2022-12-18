using DataAccessLayer.IRepository;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class Repositories<T> : IRepositories<T> where T : class
    {
        private readonly CicekPaketiDbContext cicekPaketiDbContext;

        private DbSet<T> dbSet;

        public Repositories(CicekPaketiDbContext db)
        {
            this.cicekPaketiDbContext=db;
            this.dbSet = cicekPaketiDbContext.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            dbSet.Remove(dbSet.Find(id));
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet;
        }

        public IEnumerable<T> GetFilteredList(Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter);
            
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter).FirstOrDefault();
        }

        public void RemoveRange(IEnumerable<T> entityList)
        {
            dbSet.RemoveRange(entityList);
        }

        public bool SaveChanges()
        {
           return 0<cicekPaketiDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }

    }
}
