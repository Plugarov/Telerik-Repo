using System;
using System.Collections.Generic;
using System.Web.Mvc;

using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Web.Models.Tags;
using My.Blog.Web.Common;
using My.Blog.Web.Helpers.Contracts;
using System.Linq;

namespace My.Blog.Web.Areas.Administration.Controllers
{
    public class TagsController : AdminController
    {
        private ITagService tagService;
        private IPaginator paginator;

        public TagsController(ITagService tagService, IMappingService mappingService, IPaginator paginator)
            : base(mappingService)
        {
            this.tagService = tagService ?? throw new ArgumentNullException();
            this.paginator = paginator ?? throw new ArgumentNullException();
        }

        public ActionResult All(int id = GlobalConstraints.AdminTagsPaginationStartPage, int pageSize = GlobalConstraints.AdminTagsPaginationPageSize)
        {
            var tags = tagService.GetAllAndDeleted().ToList();   
            var tagsModel = mappingService.Map<IList<Tag>, ICollection<TagAnnotaionViewModel>>(tags);

            var tagsViewModel = paginator.ApplyPagination<TagPaginationModel, TagAnnotaionViewModel>(id, pageSize, tagsModel);

            return this.View(tagsViewModel);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, Name, IsActive")]TagAnnotaionViewModel tag)
        {
            if (ModelState.IsValid)
            {
                var entity = this.mappingService.Map<Tag>(tag);

                this.tagService.Add(entity);

                return this.RedirectToAction("All");
            }

            return this.View();
        }

        public ActionResult Edit(int id)
        {
            var tag = tagService.GetById(id);
            var tagViewModel = this.mappingService.Map<TagAnnotaionViewModel>(tag);

            return this.View(tagViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Name, IsActive")]TagAnnotaionViewModel tag)
        {
            if (ModelState.IsValid)
            {
                var entity = this.mappingService.Map<Tag>(tag);

                this.tagService.Update(entity);

                return this.RedirectToAction("All");
            }

            return this.View();
        }

        public ActionResult Delete(int id)
        {
            this.tagService.Delete(id);

            return this.RedirectToAction("All");
        }

        public ActionResult Recover(int id)
        {
            this.tagService.Recover(id);

            return this.RedirectToAction("All");
        }
    }
}