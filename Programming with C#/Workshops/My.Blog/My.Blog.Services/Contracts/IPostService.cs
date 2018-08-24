using System.Collections.Generic;
using System.Linq;

using My.Blog.Data.Models;

namespace My.Blog.Services.Contracts
{
    public interface IPostService
    {
        Post GetById(int id);

        IQueryable<Post> GetAll();

        IQueryable<Post> GetAllAndDeleted();

        void AddNew(IList<Tag> tags, string postTitle, string postContent, string filename);

        void Attach(Post entity);

        void Delete(int id);

        void Recover(int id);

        void Update(Post entity);

        void SaveChanges();
    }
}
