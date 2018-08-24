using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using My.Blog.Data.Migrations;
using My.Blog.Data.Models;

namespace My.Blog.Data
{
    public class BlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public BlogDbContext()
            : base("LocalConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<PostComment> PostComments { get; set; }

        public IDbSet<Tag> Tags { get; set; }

        public IDbSet<Page> Pages { get; set; }

        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }
    }
}
