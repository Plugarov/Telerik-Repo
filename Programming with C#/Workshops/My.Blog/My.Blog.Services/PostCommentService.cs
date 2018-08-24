using System;
using System.Data.Entity;
using System.Linq;

using My.Blog.Data.Contracts;
using My.Blog.Data.Models;
using My.Blog.Services.Contracts;

namespace My.Blog.Services
{
    public class PostCommentService : IPostCommentService
    {
        public IEfDeletableEntityRepository<PostComment> postCommentRepo;
        private readonly IUserService userRepo;

        public PostCommentService(IEfDeletableEntityRepository<PostComment> postCommentRepo, IUserService userRepo)
        {
            this.postCommentRepo = postCommentRepo;
            this.userRepo = userRepo ?? throw new ArgumentNullException();

        }

        public PostComment GetById(int id)
        {
            PostComment model = null;

            model = this.postCommentRepo
                .AllAndDeleted
                .Include(c => c.Post)
                .Include(c => c.User)
                .FirstOrDefault(m => m.Id == id);

            if (model != null)
            {
                return model;
            }

            return model;
        }

        public IQueryable<PostComment> GetAll()
        {
            return this.postCommentRepo
                .All
                .Include(c => c.Post)
                .Include(c => c.User)
                .Where(m => m.Post.IsDeleted == false);
        }

        public IQueryable<PostComment> GetAllAndDeleted()
        {
            return this.postCommentRepo
                .AllAndDeleted
                .Include(c => c.Post)
                .Include(c => c.User);
        }

        public IQueryable<PostComment> GetDeleted()
        {
            return this.postCommentRepo
                .AllAndDeleted
                .Where(m => m.IsDeleted == true || m.Post.IsDeleted == true);
        }

        public void AddNew(string content, int postId)
        {
            var user = this.userRepo.Get();

            var postComment = new PostComment()
            {
                Content = content,
                User = user,
                PostId = postId
            };

            this.postCommentRepo.Add(postComment);
            this.postCommentRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.postCommentRepo.All.FirstOrDefault(x => x.Id == id);

            this.postCommentRepo.Delete(entity);
            this.postCommentRepo.SaveChanges();
        }

        public void Recover(int id)
        {
            var entity = this.postCommentRepo.AllAndDeleted.FirstOrDefault(x => x.Id == id);

            this.postCommentRepo.Recover(entity);
            this.postCommentRepo.SaveChanges();
        }

        public void Update(PostComment entity)
        {
            this.postCommentRepo.Update(entity);
            this.postCommentRepo.SaveChanges();
        }

        public void SaveChanges()
        {
            this.postCommentRepo.SaveChanges();
        }
    }
}