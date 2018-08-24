using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using My.Blog.Web.Models.Tags;
using My.Blog.Web.Common.Validators;

namespace My.Blog.Web.Models.Posts
{
    public class CreatePostViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string PostTitle { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string PostContent { get; set; }

        public IList<TagAnnotaionViewModel> Tags { get; set; }

        [Required(ErrorMessage = "Please select file.")]
        [FileSize(250240)]
        [FileTypes("jpg, jpeg, png")]
        public HttpPostedFileBase File { get; set; }
    }
}