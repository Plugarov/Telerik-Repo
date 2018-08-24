using System.Linq;

namespace My.Blog.Data.Contracts
{
    public interface IEfDeletableEntityRepository<T> : IEfGenericRepository<T> where T : class, IDeletable
    {
        IQueryable<T> AllAndDeleted { get; }

        void Delete(T entity);

        void Recover(T entity);
    }
}
