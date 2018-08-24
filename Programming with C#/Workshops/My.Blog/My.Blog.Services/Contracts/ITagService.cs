using System.Linq;

using My.Blog.Data.Models;

namespace My.Blog.Services.Contracts
{
    public interface ITagService
    {
        Tag GetById(int id);

        IQueryable<Tag> GetAll();

        IQueryable<Tag> GetAllAndDeleted();

        void Add(Tag entity);

        void Update(Tag entity);

        void Delete(int id);

        void Recover(int id);

        void SaveChanges();
    }
}
