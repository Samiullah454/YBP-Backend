using Abp.Application.Services;
using Abp.Domain.Repositories;
using HCA.WebSite_Configuration.Blog;
using HCA.Website_Configurations.Blogs.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Abp.Application.Services.Dto;

namespace HCA.Website_Configurations.Blogs
{
    public class BlogAppService : AsyncCrudAppService<Blog, BlogDto, int, PagedAndSortedResultRequestDto>
    {
        public BlogAppService(IRepository<Blog, int> repository) : base(repository)
        {
        }

        public override async Task<PagedResultDto<BlogDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = Repository.GetAllIncluding(blog => blog.BlogAuthor, blog => blog.ImageGallery);

            var totalCount = await query.CountAsync();

            return new PagedResultDto<BlogDto>
            {
                TotalCount = totalCount,
                Items = ObjectMapper.Map<List<BlogDto>>(query)
            };
        }
    }
}