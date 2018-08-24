using System.Linq;

using My.Blog.Data.Models;

namespace My.Blog.Services.Contracts
{
    public interface IPostCommentService
    {
        PostComment GetById(int id);

        IQueryable<PostComment> GetAll();

        IQueryable<PostComment> GetAllAndDeleted();
            
        IQueryable<PostComment> GetDeleted();

        void AddNew(string content, int postId);

        void Delete(int id);

        void Recover(int id);

        void Update(PostComment entity);

        void SaveChanges();
    }
}
