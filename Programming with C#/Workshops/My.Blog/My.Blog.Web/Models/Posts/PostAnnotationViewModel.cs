using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using AutoMapper;

using My.Blog.Data.Models;
using My.Blog.Web.Helpers;
using My.Blog.Web.Infrastructure.Mapping;
using My.Blog.Web.Models.Tags;

namespace My.Blog.Web.Models.Posts
{
    public class PostAnnotationViewModel : IMapFrom<Post>, IHaveCustomMappings
    {
        private BlogUrlGenerator blogUrlGenerator;

        public PostAnnotationViewModel()
            : this(new BlogUrlGenerator())
        {

        }

        public PostAnnotationViewModel(BlogUrlGenerator blogUrlGenerator)
        {
            this.blogUrlGenerator = blogUrlGenerator;
        }

        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string UserName { get; set; }

        public ICollection<TagAnnotaionViewModel> Tags { get; set; }

        public string Url
        {
            get
            {
                return blogUrlGenerator.GenerateUrl(this.Id, this.Title);
            }
        }

        public string PostImageName { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Post, PostAnnotationViewModel>().MaxDepth(0)
                .ForMember(model => model.UserName, opt => opt.MapFrom(data => data.User.UserName));
        }
    }
}