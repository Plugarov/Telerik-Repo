using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using My.Blog.Web.App_Start;
using My.Blog.Web.Infrastructure.Mapping;

namespace My.Blog.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        // when admin to be able read deleted posts from admin->posts.
        //  !!! exttract datetime now + tests
        // TODO make created date to generate in database
        // TODO Exceptions ??
        // check error when 0 posts
        // todo comments fix it. to return to comments/all/xx
        // todo parameter tampering 1:50 security video explains also why should define which properties to edit when passing model when POST
        // to do requests control 1 per 5minutes creating
        //  brute force cptcha 
        // you can find if even deleteds
        // consistency all plural sservices etc?
        // pagination to make home model the only one. make to set first prop\
        // home posts and blog in one
        // created on deleted on in models remove or add "?"
        // simplyfy tags and posts model. should not return whole model
        // add include performance
        // use one model when createing post not 2
        protected void Application_Start()
        {
            InjectingConfig.ConfigureContainer();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var mapper = new AutoMapperConfig();
            mapper.Execute(Assembly.GetExecutingAssembly());
        }
    }
}
