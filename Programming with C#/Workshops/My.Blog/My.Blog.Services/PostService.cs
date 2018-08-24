using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data.Entity;

using My.Blog.Data.Contracts;
using My.Blog.Data.Models;
using My.Blog.Services.Contracts;

namespace My.Blog.Services
{
    public class PostService : IPostService
    {
        public IEfDeletableEntityRepository<Post> postRepo;
        private IUserService userService;

        public PostService(IEfDeletableEntityRepository<Post> postRepo, IUserService userService)
        {
            this.postRepo = postRepo ?? throw new ArgumentNullException();
            this.userService = userService ?? throw new ArgumentNullException();
        }

        public Post GetById(int id)
        {
            Post entity = null;

            entity = this.postRepo.AllAndDeleted.Include(p => p.Tags).FirstOrDefault(m => m.Id == id);

            if (entity != null)
            {
                return entity;
            }

            return entity;
        }

        public IQueryable<Post> GetAll()
        {
            return this.postRepo.All
                .Include(p => p.Tags)
                .Include(p => p.User)
                .Include(p => p.PostComments)
                .Where(x => x.IsDeleted == false);
        }

        public IQueryable<Post> GetAllAndDeleted()
        {
            return this.postRepo.AllAndDeleted
                .Include(p => p.Tags)
                .Include(p => p.User)
                .Include(p => p.PostComments);
        }

        public void AddNew(IList<Tag> tags, string postTitle, string postContent, string filename)
        {
            var user = this.userService.Get();

            var entity = new Post()
            {
                Title = postTitle,
                Content = postContent,
                PostImageName = Path.GetFileName(filename),
                User = user,
                Tags = tags
            };

            this.Attach(entity);
            this.postRepo.Add(entity);
            this.postRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.postRepo.All.FirstOrDefault(x => x.Id == id);

            this.postRepo.Delete(entity);
            this.postRepo.SaveChanges();
        }

        public void Recover(int id)
        {
            var entity = this.postRepo.AllAndDeleted.FirstOrDefault(x => x.Id == id);

            this.postRepo.Recover(entity);
            this.postRepo.SaveChanges();
        }

        public void Update(Post entity)
        {
            this.postRepo.Update(entity);
            this.postRepo.SaveChanges();
        }

        public void Attach(Post entity)
        {
            this.postRepo.Attach(entity);
        }

        public void SaveChanges()
        {
            this.postRepo.SaveChanges();
        }
    }
}
