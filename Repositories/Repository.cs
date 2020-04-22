using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApiFinal.Models;
namespace WebApiFinal.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DBnews context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(DBnews context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T GetById(int id)
        {
            return entities.SingleOrDefault(s => s.ID == id);
        }
        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entities.Add(entity);
            //context.SaveChanges();
        }
        
        public void Delete(int id)
        {
            T entityToDelete = entities.Find(id);
            entities.Remove(entityToDelete);
            //context.SaveChanges();
        }
    }
}

