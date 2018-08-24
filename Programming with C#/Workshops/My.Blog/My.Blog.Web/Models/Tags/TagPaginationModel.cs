using System.Collections.Generic;

namespace My.Blog.Web.Models.Tags
{
    public class TagPaginationModel
    {
        public ICollection<TagAnnotaionViewModel> Model { get; set; }

        public int AllPages { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }
    }
}