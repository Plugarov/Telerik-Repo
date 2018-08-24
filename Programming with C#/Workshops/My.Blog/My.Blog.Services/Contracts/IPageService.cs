using System.Linq;

using My.Blog.Data.Models;

namespace My.Blog.Services.Contracts
{
    public interface IPageService
    {
        Page GetById(int id);

        IQueryable<Page> GetAll();

        IQueryable<Page> GetAllAndDeleted();

        void AddNew(string title, string content);

        void Delete(int id);

        void Recover(int id);

        void Update(Page entity);

        void SaveChanges();
    }
}
