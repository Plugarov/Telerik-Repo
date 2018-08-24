using System.ComponentModel.DataAnnotations;

namespace My.Blog.Web.Models.Pages
{
    public class CreatePageViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}