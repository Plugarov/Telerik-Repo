using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Web.Models.Posts;
using My.Blog.Web.Models.Sidebar;
using My.Blog.Web.Models.Tags;

namespace My.Blog.Web.Controllers
{
    public class SidebarController : BaseController
    {
        private ITagService tagService;
        private IPostService postService;

        public SidebarController(ITagService tagService, IPostService postService, IMappingService mappingService)
            : base(mappingService)
        {
            this.tagService = tagService ?? throw new ArgumentNullException();
            this.postService = postService ?? throw new ArgumentNullException();
        }

        public ActionResult Index()
        {
            var tags = this.tagService
                .GetAll()
                .ToList();

            var lastestPosts = this.postService
                .GetAll()
                .Take(5)
                .OrderByDescending(p => p.Id)
                .ToList();

            var tagsModel = mappingService.Map<IList<Tag>, ICollection<TagAnnotaionViewModel>>(tags);
            var recentPostsModel = mappingService.Map<IList<Post>, ICollection<PostAnnotationViewModel>>(lastestPosts);

            var sidebarViewModel = new SidebarViewModel()
            {
                Tags = tagsModel,
                RecentPosts = recentPostsModel
            };

            return this.PartialView("_SidebarPartial", sidebarViewModel);
        }
    }
}