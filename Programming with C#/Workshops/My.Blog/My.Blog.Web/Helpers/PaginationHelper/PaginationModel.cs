using System.Collections.Generic;

namespace My.Blog.Web.Helpers.PaginationHelper
{
    public class PaginationModel<T>
    {
        public ICollection<T> Model { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public int AllPages { get; set; }
    }
}