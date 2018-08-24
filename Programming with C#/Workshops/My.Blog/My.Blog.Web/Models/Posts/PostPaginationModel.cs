using System.Collections.Generic;

namespace My.Blog.Web.Models.Posts
{
    public class PostPaginationModel
    {
        public ICollection<PostAnnotationViewModel> Model { get; set; }

        public int AllPages { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }
    }
}