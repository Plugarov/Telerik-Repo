using System;
using System.Data.Entity;
using System.Linq;

using My.Blog.Data.Contracts;

namespace My.Blog.Data.Repository
{
    public class EfDeletableEntityRepository<T> : EfGenericRepository<T>, IEfDeletableEntityRepository<T> where T : class, IDeletable
    {
        public EfDeletableEntityRepository(BlogDbContext context)
            : base(context)
        {
        }

        public override IQueryable<T> All
        {
            get
            {
                return this.context.Set<T>().Where(e => e.IsDeleted == false);
            }
        }

        public IQueryable<T> AllAndDeleted
        {
            get
            {
                return this.context.Set<T>();
            }
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.Now;

            var entry = this.context.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public void Recover(T entity)
        {
            entity.IsDeleted = false;
            entity.DeletedOn = DateTime.Now;

            var entry = this.context.Entry(entity);
            entry.State = EntityState.Modified;
        }
    }
}
