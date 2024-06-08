using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using HCA.Industry.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace HCA.Industry
{
    public class IndustryAppService : AsyncCrudAppService<Industry, IndustryDto, Guid, PagedAndSortedResultRequestDto, CreateIndustryInputDto, UpdateIndustryInputDto>, IIndustryAppService
    {
        public IndustryAppService(IRepository<Industry, Guid> repository)
            : base(repository)
        {
        }

        public override async Task<PagedResultDto<IndustryDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = Repository.GetAllIncluding(industry => industry.Packages);

            var totalCount = await query.CountAsync();

            // Apply sorting and paging here as needed
            var industries = await query.ToListAsync();

            var industryDtos = ObjectMapper.Map<List<IndustryDto>>(industries);

            // Adding the count of packages to each DTO
            foreach (var industryDto in industryDtos)
            {
                industryDto.PackageCount = industries.FirstOrDefault(ind => ind.Id == industryDto.Id)?.Packages?.Count ?? 0;
            }

            return new PagedResultDto<IndustryDto>(totalCount, industryDtos);
        }
    }
}
