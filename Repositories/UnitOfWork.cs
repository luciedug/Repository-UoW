using System;
using System.Threading.Tasks;

namespace WebApiFinal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBnews _databaseContext;
        private Lazy<NewsRepository>_newsRepository;

        public UnitOfWork(DBnews databaseContext)
        {   _databaseContext = databaseContext;
            _newsRepository = new Lazy<NewsRepository>(() => new NewsRepository(databaseContext));
        }

        public IRepositoryNew NewsRepository
        {
            get { return _newsRepository.Value; }
        }

       
        public async Task CommitAsync()
        {
           await _databaseContext.SaveChangesAsync(); }

        public void Rollback()
        { _databaseContext.Dispose(); }
    }
}
