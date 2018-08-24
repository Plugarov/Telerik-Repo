using System;
using System.Web.Mvc;

using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Web.Models.Posts;

namespace My.Blog.Web.Controllers
{
    public class BlogController : BaseController
    {
        private readonly IPostService postService;

        public BlogController(IPostService postService, IMappingService mappingService)
            : base(mappingService)
        {

            this.postService = postService ?? throw new ArgumentNullException();
        }

        public ActionResult Post(int id)
        {
            var post = this.postService.GetById(id);

            if (post == null || post.IsDeleted)
            {
                return this.HttpNotFound("Blog post not found");
            }

            var postViewModel = base.mappingService.Map<Post, PostAnnotationViewModel>(post);

            return this.View(postViewModel);
        }
    }
}