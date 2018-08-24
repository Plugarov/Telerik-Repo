using System.Linq;

namespace My.Blog.Data.Contracts
{
    public interface IEfGenericRepository<T> where T : class
    {
        IQueryable<T> All { get; }

        void Add(T entity);

        void Attach(T entity);

        void Update(T entity);

        void SaveChanges();
    }
}
