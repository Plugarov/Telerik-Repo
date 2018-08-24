using System;
using System.Web.Mvc;

using My.Blog.Services.Contracts;

namespace My.Blog.Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IMappingService mappingService;

        public BaseController(IMappingService mappingService)
        {
            this.mappingService = mappingService ?? throw new ArgumentNullException();
        }
    }
}