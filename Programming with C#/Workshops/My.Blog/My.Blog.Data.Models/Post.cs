using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using My.Blog.Data.Contracts;

namespace My.Blog.Data.Models
{
    public class Post : DeletableEntity, IDeletable
    {
        private ICollection<PostComment> postComments;
        private ICollection<Tag> tags;

        public Post()
        {
            this.postComments = new HashSet<PostComment>();
            this.tags = new HashSet<Tag>();
            this.CreatedOn = DateTime.Now;
        }

        public virtual ApplicationUser User { get; set; }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Html)]
        public string Content { get; set; }

        public string PostImageName { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<PostComment> PostComments
        {
            get
            {
                return this.postComments;
            }
            set
            {
                this.postComments = value;
            }
        }

        public virtual ICollection<Tag> Tags
        {
            get
            {
                return this.tags;
            }
            set
            {
                this.tags = value;
            }
        }
    }
}
