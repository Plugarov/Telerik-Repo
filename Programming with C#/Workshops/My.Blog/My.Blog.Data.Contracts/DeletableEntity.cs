using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My.Blog.Data.Contracts
{
    public abstract class DeletableEntity : IDeletable
    {
        public DeletableEntity()
        {
            this.IsDeleted = true;
        }

        [Display(Name = "Deleted?")]
        public bool IsDeleted { get; set; }

        [Display(Name = "Deletion date")]
        [Column(TypeName = "datetime2")]
        public DateTime? DeletedOn { get; set; }
    }
}
