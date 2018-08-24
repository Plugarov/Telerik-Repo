using My.Blog.Data.Contracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace My.Blog.Data.Models
{
    public class Tag : DeletableEntity, IDeletable
    {
        private ICollection<Post> posts;

        public Tag()
        {
            this.posts = new HashSet<Post>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Post> Posts
        {
            get
            {
                return this.posts;
            }
            set
            {
                this.posts = value;
            }
        }
    }
}

