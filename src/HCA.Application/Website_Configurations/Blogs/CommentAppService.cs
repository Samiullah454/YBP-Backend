using Abp.Application.Services;
using Abp.Domain.Repositories;
using HCA.WebSite_Configuration.Blog;
using HCA.Website_Configurations.Blogs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Website_Configurations.Blogs
{
    public class CommentAppService : AsyncCrudAppService<BlogComment, BlogCommentDto, int>
    {
        public CommentAppService(IRepository<BlogComment, int> repository) : base(repository)
        {
        }
    }
}