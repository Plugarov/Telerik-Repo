using System.Collections.Generic;

using My.Blog.Web.Models.Posts;

namespace My.Blog.Web.Models.Home
{
    public class HomePaginationModel
    {
        public ICollection<PostAnnotationViewModel> Model { get; set; }

        public int AllPages { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }
    }
}