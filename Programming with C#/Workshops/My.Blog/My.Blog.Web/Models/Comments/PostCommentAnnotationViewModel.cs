using System;
using System.ComponentModel.DataAnnotations;

using AutoMapper;

using My.Blog.Data.Models;
using My.Blog.Web.Infrastructure.Mapping;

namespace My.Blog.Web.Models.Comments
{
    public class PostCommentAnnotationViewModel : IMapFrom<PostComment>, IHaveCustomMappings
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int PostId { get; set; }

        public string PostTitle { get; set; }

        public string UserName { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<PostComment, PostCommentAnnotationViewModel>()
                .ForMember(model => model.PostTitle, opt => opt.MapFrom(data => data.Post.Title))
                .ForMember(model => model.PostId, opt => opt.MapFrom(data => data.Post.Id))
                .ForMember(model => model.UserName, opt => opt.MapFrom(data => data.User.UserName));
        }
    }
}