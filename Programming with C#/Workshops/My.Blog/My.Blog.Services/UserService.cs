using System;
using System.Linq;
using System.Security.Principal;

using Microsoft.AspNet.Identity;

using My.Blog.Data.Contracts;
using My.Blog.Data.Models;
using My.Blog.Services.Contracts;

namespace My.Blog.Services
{
    public class UserService : IUserService
    {
        private readonly IIdentity currentIdentity;
        private readonly IEfGenericRepository<ApplicationUser> usersRepo;

        public UserService(IIdentity identity, IEfGenericRepository<ApplicationUser> usersRepo)
        {
            this.currentIdentity = identity;
            this.usersRepo = usersRepo;
        }

        public ApplicationUser Get()
        {
            var currentUserId = this.currentIdentity.GetUserId();

            var user = this.usersRepo.All.FirstOrDefault(u => u.Id == currentUserId);

            return user;
        }

        public bool IsAdmin()
        {
            throw new NotImplementedException();
        }
    }
}
