using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

using My.Blog.Data;
using My.Blog.Data.Contracts;
using My.Blog.Data.Repository;
using My.Blog.Services;
using My.Blog.Services.Contracts;
using My.Blog.Web.Helpers;
using My.Blog.Web.Helpers.Contracts;
using My.Blog.Web.Helpers.PaginationHelper;


namespace My.Blog.Web.App_Start
{
    public class InjectingConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.Register(c => HttpContext.Current.User.Identity).As<IIdentity>();

            builder.RegisterType<MappingService>().As<IMappingService>().SingleInstance();

            builder.RegisterType<BlogUrlGenerator>().As<IBlogUrlGenerator>();
            builder.RegisterType<Paginator>().As<IPaginator>();

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<PostCommentService>().As<IPostCommentService>();
            builder.RegisterType<TagService>().As<ITagService>();
            builder.RegisterType<PostService>().As<IPostService>();
            builder.RegisterType<PageService>().As<IPageService>();

            builder.RegisterGeneric(typeof(EfGenericRepository<>)).As(typeof(IEfGenericRepository<>));
            builder.RegisterGeneric(typeof(EfDeletableEntityRepository<>)).As(typeof(IEfDeletableEntityRepository<>));

            builder.RegisterType<BlogDbContext>().InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}