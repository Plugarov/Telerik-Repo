using System.Linq;
using System.Data.Entity;

using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Data.Contracts;

namespace My.Blog.Services
{
    public class TagService : ITagService
    {
        public IEfDeletableEntityRepository<Tag> tagRepo;

        public TagService(IEfDeletableEntityRepository<Tag> tagRepo)
        {
            this.tagRepo = tagRepo;
        }

        public Tag GetById(int id)
        {
            Tag model = null;

            model = this.tagRepo
                .All
                .Include(t => t.Posts)
                .FirstOrDefault(m => m.Id == id);

            if (model != null)
            {
                return model;
            }

            return model;
        }

        public IQueryable<Tag> GetAll()
        {
            return this.tagRepo.All.Include(t => t.Posts);
        }

        public IQueryable<Tag> GetAllAndDeleted()
        {
            return this.tagRepo.AllAndDeleted.Include(t => t.Posts);
        }

        public void Add(Tag entity)
        {
            this.tagRepo.Add(entity);
            this.tagRepo.SaveChanges();
        }

        public void Update(Tag entity)
        {
            this.tagRepo.Update(entity);
            this.tagRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.tagRepo.All.FirstOrDefault(x => x.Id == id);

            this.tagRepo.Delete(entity);
            this.tagRepo.SaveChanges();
        }

        public void Recover(int id)
        {
            var entity = this.tagRepo.AllAndDeleted.FirstOrDefault(x => x.Id == id);

            this.tagRepo.Recover(entity);
            this.tagRepo.SaveChanges();
        }

        public void SaveChanges()
        {
            this.tagRepo.SaveChanges();
        }
    }
}

