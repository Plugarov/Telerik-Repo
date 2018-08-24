using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Linq;

using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Web.Models.Posts;
using My.Blog.Web.Helpers.Contracts;
using My.Blog.Web.Models.Tags;
using My.Blog.Web.Common;

namespace My.Blog.Web.Areas.Administration.Controllers
{
    public class PostsController : AdminController
    {
        private readonly IPostService postService;
        private readonly ITagService tagService;
        private readonly IPaginator paginator;

        public PostsController(ITagService tagService, IPostService postService, IPaginator paginator,
             IMappingService mappingService)
            : base(mappingService)
        {
            this.postService = postService ?? throw new ArgumentNullException();
            this.tagService = tagService ?? throw new ArgumentNullException();
            this.paginator = paginator ?? throw new ArgumentNullException();
        }

        public ActionResult All(int id = GlobalConstraints.AdminPostsPaginationStartPage, int pageSize = GlobalConstraints.AdminPostsPaginationPageSize)
        {
            var posts = this.postService.GetAllAndDeleted().OrderByDescending(x => x.CreatedOn).ToList();
            var postsModel = mappingService.Map<IList<Post>, ICollection<PostAnnotationViewModel>>(posts);

            var postsViewModel = paginator.ApplyPagination<PostPaginationModel, PostAnnotationViewModel>(id, pageSize, postsModel);

            return this.View(postsViewModel);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PostTitle, PostContent, Tags, File")] CreatePostViewModel model)
        {
            if (ModelState.IsValid)
            {

                if (model.File != null)
                {
                    string _fileName = Path.GetFileName(model.File.FileName);
                    string _path = Path.Combine(Server.MapPath(GlobalConstraints.PostImageFolderPath), _fileName);
                    model.File.SaveAs(_path);

                    var tags = model.Tags.Where(m => m.IsDeleted == true).ToList();

                    var tagsModel = mappingService.Map<ICollection<TagAnnotaionViewModel>, IList<Tag>>(tags);

                    this.postService.AddNew(tagsModel, model.PostTitle, model.PostContent, _fileName);

                    return this.RedirectToAction("All");
                }

                return this.RedirectToAction("Index");
            }

            return this.View();
        }

        public ActionResult Edit(int id)
        {
            var post = this.postService.GetById(id);
            var postViewModel = mappingService.Map<PostAnnotationViewModel>(post);

            return this.View(postViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Title, Content, CreatedOn, IsDeleted, DeletedOn, PostImageName")]PostAnnotationViewModel post)
        {
            if (ModelState.IsValid)
            {
                var entity = this.mappingService.Map<PostAnnotationViewModel, Post>(post);

                this.postService.Update(entity);

                return this.RedirectToAction("All", "Posts", null);
            }

            return this.View();
        }

        [ChildActionOnly]
        public ActionResult AddTags()
        {
            var tags = this.tagService.GetAll();
            var tagsModel = this.mappingService.Map<IEnumerable<Tag>, IList<TagAnnotaionViewModel>>(tags);

            var tagsViewModel = new TagsViewModel()
            {
                Tags = tagsModel
            };

            return this.PartialView("_AddTags", tagsViewModel);
        }

        public ActionResult Delete(int id)
        {
            this.postService.Delete(id);

            return this.RedirectToAction("All");
        }

        public ActionResult Recover(int id)
        {
            this.postService.Recover(id);

            return this.RedirectToAction("All");
        }
    }
}