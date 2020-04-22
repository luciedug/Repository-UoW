using System.Collections.Generic;
using WebApiFinal.Models;

namespace WebApiFinal.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Delete(int id);
    }
}
