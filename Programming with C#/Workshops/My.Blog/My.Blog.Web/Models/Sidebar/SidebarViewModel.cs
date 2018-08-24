using System.Collections.Generic;

using My.Blog.Web.Models.Posts;
using My.Blog.Web.Models.Tags;

namespace My.Blog.Web.Models.Sidebar
{
    public class SidebarViewModel
    {
        public IEnumerable<TagAnnotaionViewModel> Tags { get; set; }

        public IEnumerable<PostAnnotationViewModel> RecentPosts { get; set; }
    }
}