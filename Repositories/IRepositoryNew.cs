using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiFinal.Models;

namespace WebApiFinal.Repositories
{
    public interface IRepositoryNew
    {
        Task<IEnumerable<New>> GetAllAsync();
        Task<New> GetbyIdAsync(int id);
        void InsertNew(New n);
        void DeleteNew(int id);
    }
}
