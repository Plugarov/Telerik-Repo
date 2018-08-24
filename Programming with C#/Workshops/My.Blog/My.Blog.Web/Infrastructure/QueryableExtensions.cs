using System;
using System.Linq;
using System.Linq.Expressions;

using AutoMapper.QueryableExtensions;

using My.Blog.Web.Infrastructure.Mapping;

namespace My.Blog.Web.Infrastructure
{
    public static class QueryableExtensions
    {
        public static IQueryable<TDestination> MapTo<TDestination>(this IQueryable source, params Expression<Func<TDestination, object>>[] membersToExpand)
        {
            return source.ProjectTo(AutoMapperConfig.Configuration, membersToExpand);
        }
    }
}