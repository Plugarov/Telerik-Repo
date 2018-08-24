using System.Collections.Generic;

namespace My.Blog.Services.Contracts
{
    public interface IMappingService
    {
        T Map<T>(object source);

        TDestination Map<TSource, TDestination>(TSource model);
    }
}
