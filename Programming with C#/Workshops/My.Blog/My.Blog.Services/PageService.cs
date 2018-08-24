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
    public class PageService : IPageService
    {
        public IEfDeletableEntityRepository<Page> pageRepo;
        private IUserService userService;

        public PageService(IEfDeletableEntityRepository<Page> pageRepo, IUserService userService)
        {
            this.pageRepo = pageRepo ?? throw new ArgumentNullException();
            this.userService = userService;
        }

        public Page GetById(int id)
        {
            Page entity = null;

            entity = this.pageRepo.AllAndDeleted.FirstOrDefault(m => m.Id == id);

            if (entity != null)
            {
                return entity;
            }

            return entity;
        }

        public IQueryable<Page> GetAll()
        {
            return this.pageRepo.All.Include(p => p.User).Where(x => x.IsDeleted == false);
        }

        public IQueryable<Page> GetAllAndDeleted()
        {
            return this.pageRepo.AllAndDeleted.Include(p => p.User);
        }

        public void AddNew(string title, string content)
        {
            var user = this.userService.Get();

            var entity = new Page()
            {
                Title = title,
                Content = content,
                User = user
            };

            this.pageRepo.Add(entity);
            this.pageRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.pageRepo.All.FirstOrDefault(x => x.Id == id);

            this.pageRepo.Delete(entity);
            this.pageRepo.SaveChanges();
        }

        public void Recover(int id)
        {
            var entity = this.pageRepo.AllAndDeleted.FirstOrDefault(x => x.Id == id);

            this.pageRepo.Recover(entity);
            this.pageRepo.SaveChanges();
        }

        public void Update(Page entity)
        {
            this.pageRepo.Update(entity);
            this.pageRepo.SaveChanges();
        }

        public void Attach(Page entity)
        {
            this.pageRepo.Attach(entity);
        }

        public void SaveChanges()
        {
            this.pageRepo.SaveChanges();
        }
    }
}
