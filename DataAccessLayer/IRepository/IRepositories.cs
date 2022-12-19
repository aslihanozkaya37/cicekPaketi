using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    public interface IRepositories<T> where T : class
    {
        /// <summary>
        /// List olarak hepsini getirir.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Veritabanına ekler.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
       void Add(T entity);
        /// <summary>
        /// Filtreleme yaparak geri tek bir kayıt döndürür.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        /// <summary>
        /// Filtreleme yaparak geri liste döndürür.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        IEnumerable<T> GetFilteredList(Expression<Func<T, bool>> filter);
        /// <summary>
        /// id'si verilen kaydı siler.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void Delete(int id);
        /// <summary>
        /// Gelen kaydı veritabanında günceller
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Update(T entity);
        /// <summary>
        /// Id si verilen kayıtları çoklu siler.
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        void RemoveRange(IEnumerable<T> entity);
        
    }
}
