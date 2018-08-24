using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Web.Common;
using My.Blog.Web.Helpers.Contracts;
using My.Blog.Web.Models.Home;
using My.Blog.Web.Models.Posts;

namespace My.Blog.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IPostService postService;
        private readonly IPaginator paginator;

        public HomeController(IPostService postService, IMappingService mappingService, IPaginator paginator)
            : base(mappingService)
        {
            this.postService = postService ?? throw new ArgumentNullException();
            this.paginator = paginator ?? throw new ArgumentNullException();
        }

        public ActionResult Index(int id = GlobalConstraints.HomePaginationStartPage, int pageSize = GlobalConstraints.HomePaginationPageSize)
        {
            var posts = this.postService
                .GetAll()
                .OrderByDescending(x => x.CreatedOn)
                .ToList();

            var postsModel = mappingService.Map<IList<Post>, ICollection<PostAnnotationViewModel>>(posts);

            var postsViewModel = paginator.ApplyPagination<HomePaginationModel, PostAnnotationViewModel>(id, pageSize, postsModel);

            return this.View(postsViewModel);
        }
    }
}