using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using My.Blog.Data.Contracts;

namespace My.Blog.Data.Models
{
    public class Page : DeletableEntity, IDeletable
    {
        public Page()
        {
            this.CreatedOn = DateTime.Now;
        }

        public virtual ApplicationUser User { get; set; }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Html)]
        public string Content { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedOn { get; set; }
    }
}
