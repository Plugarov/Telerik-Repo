using System.Collections.Generic;

namespace My.Blog.Web.Models.Comments
{
    public class PostCommentPaginationModel
    {
        public ICollection<PostCommentAnnotationViewModel> Model { get; set; }

        public int AllPages { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }
    }
}