using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiFinal.Models;
namespace WebApiFinal.Repositories
{
    public class NewsRepository : IRepositoryNew
    {
        protected readonly DBnews context;
        private DbSet<New> entities;
        public NewsRepository(DBnews context) 
        {
            this.context = context;
            entities = context.Set<New>();
        }
        public async Task<IEnumerable<New>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }
        public async Task<New> GetbyIdAsync(int id)
        {
            return await entities.AsNoTracking()
                .FirstOrDefaultAsync(e => e.ID== id);
        }
        public void InsertNew(New n)
        {
            if (n == null) throw new ArgumentNullException("entity");

            entities.Add(n);
        }
        public void DeleteNew(int id)
        {
            New newsToDelete = entities.Find(id);
            entities.Remove(newsToDelete);
        }
    }
}
