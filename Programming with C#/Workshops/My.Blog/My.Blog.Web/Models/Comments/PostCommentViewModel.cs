using System.Collections.Generic;

namespace My.Blog.Web.Models.Comments
{
    public class PostCommentViewModel
    {
        public ICollection<PostCommentAnnotationViewModel> Comments { get; set; }
    }
}