using System.Threading.Tasks;

namespace WebApiFinal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBnews _databaseContext;
        private IRepositoryNew _newsRepository;

        public UnitOfWork(DBnews databaseContext)
        { _databaseContext = databaseContext; }

        public IRepositoryNew NewsRepository
        {
            get { return _newsRepository = _newsRepository ?? new NewsRepository(_databaseContext); }
        }
        public async Task CommitAsync()
        {
           await _databaseContext.SaveChangesAsync(); }

        public void Rollback()
        { _databaseContext.Dispose(); }
    }
}
