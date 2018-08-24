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

    public class TagsController : BaseController
    {
        private readonly ITagService tagService;
        private readonly IPaginator paginator;

        public TagsController(ITagService tagService, IMappingService mappingService, IPaginator paginator)
            : base(mappingService)
        {
            this.tagService = tagService ?? throw new ArgumentNullException();
            this.paginator = paginator ?? throw new ArgumentNullException();
        }

        public ActionResult ByTag(int id, int pageId = GlobalConstraints.HomePaginationStartPage, int pageSize = GlobalConstraints.HomePaginationPageSize)
        {
            var posts = this.tagService.GetById(id)
                .Posts
                .ToList();

            var postsModel = mappingService.Map<IList<Post>, ICollection<PostAnnotationViewModel>>(posts);

            var postsViewModel = paginator.ApplyPagination<HomePaginationModel, PostAnnotationViewModel>(pageId, pageSize, postsModel);

            this.ViewData["TagId"] = id;

            return this.View(postsViewModel);
        }
    }
}