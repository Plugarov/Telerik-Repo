using System.Web.Mvc;
using System.Web.Routing;

namespace My.Blog.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Page",
                url: "pages/{permalink}",
                defaults: new { controller = "Pages", action = "Page" },
                namespaces: new[] { "My.Blog.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Tags",
                url: "tags/{id}",
                defaults: new { controller = "Tags", action = "ByTag" },
                namespaces: new[] { "My.Blog.Web.Controllers" }
            );

            routes.MapRoute(
                 name: "Blog",
                 url: "blog/{id}/{title}",
                 defaults: new { controller = "Blog", action = "Post" },
                 constraints: new { id = @"\d+" }
             );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: null,
                namespaces: new[] { "My.Blog.Web.Controllers" }
            );

            routes.MapRoute(
                 name: "RusBlog",
                 url: "ru/blog/{id}/{title}",
                 defaults: new { controller = "Blog", action = "Post" },
                 constraints: new { id = @"\d+" }
            );

            routes.MapRoute(
                name: "RusDefault",
                url: "ru/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: null,
                namespaces: new[] { "My.Blog.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Pagination",
                url: "{controller}/{action}/{id}/{pageSize}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, pageSize = UrlParameter.Optional },
                constraints: null,
                namespaces: new[] { "My.Blog.Web.Controllers" }
            );


        }
    }
}
