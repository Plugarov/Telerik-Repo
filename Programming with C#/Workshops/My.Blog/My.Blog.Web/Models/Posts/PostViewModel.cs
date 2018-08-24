using System.Collections.Generic;

namespace My.Blog.Web.Models.Posts
{
    public class PostViewModel
    {
        public ICollection<PostAnnotationViewModel> Posts { get; set; }
    }
}