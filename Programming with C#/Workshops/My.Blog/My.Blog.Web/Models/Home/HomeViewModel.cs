using System.Collections.Generic;

using My.Blog.Web.Models.Posts;

namespace My.Blog.Web.Models.Home
{
    public class HomeViewModel
    {
        public ICollection<PostAnnotationViewModel> Posts { get; set; }
    }
}