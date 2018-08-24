using System;
using System.Web.Mvc;

using My.Blog.Services.Contracts;
using My.Blog.Web.Common;

namespace My.Blog.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = GlobalConstraints.AdministratorRoleName)]
    [ValidateInput(false)]
    public class AdminController : Controller
    {
        protected readonly IMappingService mappingService;

        public AdminController(IMappingService mappingService)
        {
            this.mappingService = mappingService ?? throw new ArgumentNullException();
        }
    }
}