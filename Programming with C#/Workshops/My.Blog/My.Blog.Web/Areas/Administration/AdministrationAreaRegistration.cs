using System.Web.Mvc;

namespace My.Blog.Web.Areas.Administration
{
    public class AdministrationAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Administration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Administration_default",
                "administration/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "My.Blog.Web.Areas.Administration.Controllers" }
            );

            context.MapRoute(
                "Administration_default_rus",
                "ru/administration/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "My.Blog.Web.Areas.Administration.Controllers" }
            );
    
            context.MapRoute(
                name: "Administration_pagination",
                url: "administration/{controller}/{action}/{id}/{pageSize}",
                defaults: new { action = "Index", id = UrlParameter.Optional, pageSize = UrlParameter.Optional },
                namespaces: new[] { "My.Blog.Web.Areas.Administration.Controllers" }
            );
        }
    }
}