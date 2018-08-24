using System;
using System.Linq;
using System.Web.Mvc;
using My.Blog.Data.Models;
using My.Blog.Services.Contracts;
using My.Blog.Web.Helpers.Contracts;
using My.Blog.Web.Models.Pages;

namespace My.Blog.Web.Controllers
{

    public class PagesController : BaseController
    {
        private readonly IPaginator paginator;
        private readonly IPageService pageService;

        public PagesController(IMappingService mappingService, IPageService pageService, IPaginator paginator)
            : base(mappingService)
        {
            this.paginator = paginator ?? throw new ArgumentNullException();
            this.pageService = pageService ?? throw new ArgumentNullException();
        }

        public ActionResult Page(string permalink)
        {
            var page = pageService
                .GetAll()
                .Where(p => p.Title.ToLower().Trim() == permalink.ToLower().Trim())
                .FirstOrDefault();

            if (page != null)
            {
                var pageViewModel = mappingService.Map<Page, PageAnnotationViewModel>(page);

                return this.View(pageViewModel);
            }

            return this.HttpNotFound("Page not found!");
        }
    }
}