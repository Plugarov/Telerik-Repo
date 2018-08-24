using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Web.Models.Pages;
using My.Blog.Web.Models.Posts;

namespace My.Blog.Web.Areas.Administration.Controllers
{
    public class PagesController : AdminController
    {
        private IPageService pageService;

        public PagesController(IMappingService mappingService, IPageService pageService)
            : base(mappingService)
        {
            this.pageService = pageService;
        }

        public ActionResult All()
        {
            var pages = this.pageService.GetAllAndDeleted().OrderByDescending(x => x.CreatedOn).ToList();
            var pagesModels = mappingService.Map<IList<Page>, ICollection<PageAnnotationViewModel>>(pages);

            var pageViewModel = new PageViewModel()
            {
                Pages = pagesModels
            };

            return this.View(pageViewModel);
        }


        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Title, Content")]CreatePageViewModel model)
        {
            if (ModelState.IsValid)
            {
                pageService.AddNew(model.Title, model.Content);

                return this.RedirectToAction("All");
            }

            return this.RedirectToAction("All");
        }

        public ActionResult Edit(int id)
        {
            var post = this.pageService.GetById(id);
            var postViewModel = mappingService.Map<PageAnnotationViewModel>(post);

            return this.View(postViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, Title, Content, CreatedOn, IsDeleted, DeletedOn")]PageAnnotationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = this.mappingService.Map<PageAnnotationViewModel, Page>(model);

                this.pageService.Update(entity);

                return this.RedirectToAction("All", "Pages", null);
            }

            return this.View();
        }

        public ActionResult Delete(int id)
        {
            this.pageService.Delete(id);

            return this.RedirectToAction("All");
        }

        public ActionResult Recover(int id)
        {
            this.pageService.Recover(id);

            return this.RedirectToAction("All");
        }
    }
}