using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using My.Blog.Data.Contracts;

namespace My.Blog.Data.Models
{
    public class PostComment : DeletableEntity, IDeletable
    {
        public PostComment()
        {
            this.CreatedOn = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedOn { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        [Required]
        public string Content { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
