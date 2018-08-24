using System;
using System.Collections.Generic;

using AutoMapper;

using My.Blog.Services.Contracts;

namespace My.Blog.Services
{
    public class MappingService : IMappingService
    {
        public T Map<T>(object source)
        {
            return Mapper.Map<T>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource model)
        {
            return Mapper.Map<TSource, TDestination>(model);
        }
    }
}