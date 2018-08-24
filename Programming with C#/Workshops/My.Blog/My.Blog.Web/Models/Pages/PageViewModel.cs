using System.Collections.Generic;

namespace My.Blog.Web.Models.Pages
{
    public class PageViewModel
    {
        public ICollection<PageAnnotationViewModel> Pages { get; set; }
    }
}