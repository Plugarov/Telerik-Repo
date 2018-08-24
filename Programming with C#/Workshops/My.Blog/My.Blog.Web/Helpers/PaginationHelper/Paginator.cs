using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using My.Blog.Web.Helpers.Contracts;

namespace My.Blog.Web.Helpers.PaginationHelper
{
    public class Paginator : IPaginator
    {
        public T1 ApplyPagination<T1, T2>(int id, int pageSize, IEnumerable<T2> entities)
        {
            var entitiesCount = entities.Count();

            int page = 0;
            int pages = 0;

            ICollection<T2> model;

            if (entitiesCount == 0)

            {
                model = new List<T2>();
            }
            else
            {
                if (entitiesCount % pageSize == 0)
                {
                    pages = entitiesCount / pageSize;
                }
                else
                {
                    pages = (entitiesCount / pageSize) + 1;
                }

                if (id < 1)
                {
                    id = 1;
                }
                else if (id > pages)
                {
                    id = pages;
                }

                if (pageSize < 1)
                {
                    pageSize = 10;
                }

                page = id;

                model = entities.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }

            var viewModel = (T1)Activator.CreateInstance(typeof(T1));
            var type = viewModel.GetType();

            PropertyInfo modelProp = type.GetProperty("Model");
            PropertyInfo pageProp = type.GetProperty("CurrentPage");
            PropertyInfo pageSizeProp = type.GetProperty("PageSize");
            PropertyInfo pagesProp = type.GetProperty("AllPages");

            modelProp.SetValue(viewModel, model);
            pageProp.SetValue(viewModel, page);
            pageSizeProp.SetValue(viewModel, pageSize);
            pagesProp.SetValue(viewModel, pages);

            return viewModel;
        }
    }
}
