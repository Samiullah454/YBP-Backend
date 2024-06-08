using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HCA.WebSite_Configuration.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Website_Configurations.Blogs.Dtos
{
    [AutoMap(typeof(Blog))]
    public class BlogDto : EntityDto<int>
    {
        public string Headerimgurl { get; set; }
        public string Title { get; set; }
        public string BlogText { get; set; }
        public int Comments { get; set; }
        public int Views { get; set; }
        public int BlogAuthorId { get; set; }
        public DateTime Date { get; set; }
        public BlogImageGalleryDto ImageGallery { get; set; }
        public string Blockquote { get; set; }
        public BlogBottomDto BlogBottom { get; set; }
        // public ICollection<BlogCommentDto> CommentsList { get; set; }
    }

    [AutoMap(typeof(BlogAuthor))]
    public class BlogAuthorDto : EntityDto<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ImageSource { get; set; }
        public ICollection<BlogDto> Blogs { get; set; }
    }

    [AutoMap(typeof(BlogImageGallery))]
    public class BlogImageGalleryDto : EntityDto<int>
    {
        public string Image1Source { get; set; }
        public string Image2Source { get; set; }
        // public ICollection<BlogDto> Blogs { get; set; }
    }

    [AutoMap(typeof(BlogBottom))]
    public class BlogBottomDto : EntityDto<int>
    {
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string GooglePlusLink { get; set; }
        public string LinkedInLink { get; set; }
        public string PinterestLink { get; set; }
        // public ICollection<BlogDto> Blogs { get; set; }
    }

    [AutoMap(typeof(BlogComment))]
    public class BlogCommentDto : EntityDto<int>
    {
        public int BlogId { get; set; }
        public int AuthorId { get; set; }
        public DateTime CommentDate { get; set; }
        public string Text { get; set; }
    }
}