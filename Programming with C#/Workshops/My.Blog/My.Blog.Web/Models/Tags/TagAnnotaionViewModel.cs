using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using AutoMapper;

using My.Blog.Data.Models;
using My.Blog.Web.Infrastructure.Mapping;
using My.Blog.Web.Models.Posts;

namespace My.Blog.Web.Models.Tags
{
    public class TagAnnotaionViewModel : IMapFrom<Tag>, IHaveCustomMappings
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<PostAnnotationViewModel> Posts { get; set; }

        public DateTime? DeletedOn { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Tag, TagAnnotaionViewModel>()
                         .ForMember(model => model.Posts, opt => opt.Ignore());
        }
    }
}