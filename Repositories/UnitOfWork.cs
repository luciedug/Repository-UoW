using WebApiFinal.Models;

namespace WebApiFinal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBnews _databaseContext;
        private IRepository<New> _newsRepository;

        public UnitOfWork(DBnews databaseContext)
        { _databaseContext = databaseContext; }

        public IRepository<New> NewsRepository
        {
            get { return _newsRepository = _newsRepository ?? new Repository<New>(_databaseContext); }
        }
        public void Commit()
        { _databaseContext.SaveChanges(); }

        public void Rollback()
        { _databaseContext.Dispose(); }
    }
}
