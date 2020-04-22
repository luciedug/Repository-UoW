using System;
using WebApiFinal.Models;

namespace WebApiFinal.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<New> NewsRepository { get; }
        void Commit();
        void Rollback();
    }
}
