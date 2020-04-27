using System.Threading.Tasks;

namespace WebApiFinal.Repositories
{
    public interface IUnitOfWork
    {
        IRepositoryNew NewsRepository { get; }
        Task CommitAsync();
        void Rollback();
    }
}
