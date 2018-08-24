using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using My.Blog.Data.Contracts;

namespace My.Blog.Data.Repository
{
    public class EfGenericRepository<T> : IEfGenericRepository<T> where T : class
    {
        public readonly BlogDbContext context;

        public EfGenericRepository(BlogDbContext context)
        {
            this.context = context;
        }

        public virtual IQueryable<T> All
        {
            get
            {
                return this.context.Set<T>();
            }
        }

        public void Add(T entity)
        {
            DbEntityEntry entry = this.context.Entry(entity);

            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.context.Set<T>().Add(entity);
            }
        }

        public void Attach(T entity)
        {
            this.context.Set<T>().Attach(entity);
        }

        public void Update(T entity)
        {
            DbEntityEntry entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.context.Set<T>().Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
