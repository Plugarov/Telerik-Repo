using System;
using System.ComponentModel.DataAnnotations;

using AutoMapper;

using My.Blog.Data.Models;
using My.Blog.Web.Helpers;
using My.Blog.Web.Infrastructure.Mapping;

namespace My.Blog.Web.Models.Pages
{
    public class PageAnnotationViewModel : IMapFrom<Page>, IHaveCustomMappings
    {
        private BlogUrlGenerator blogUrlGenerator;

        public PageAnnotationViewModel()
            : this(new BlogUrlGenerator())
        {

        }

        public PageAnnotationViewModel(BlogUrlGenerator blogUrlGenerator)
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

        public string Url
        {
            get
            {
                return blogUrlGenerator.GenerateUrl(this.Id, this.Title);
            }
        }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Page, PageAnnotationViewModel>().MaxDepth(0)
                .ForMember(model => model.UserName, opt => opt.MapFrom(data => data.User.UserName));
        }
    }
}