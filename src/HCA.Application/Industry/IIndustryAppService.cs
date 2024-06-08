using Abp.Application.Services.Dto;
using Abp.Application.Services;
using HCA.Industry.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Industry
{
    public interface IIndustryAppService : IAsyncCrudAppService<IndustryDto, Guid, PagedAndSortedResultRequestDto, CreateIndustryInputDto, UpdateIndustryInputDto>
    {
        public Task<PagedResultDto<IndustryDto>> GetAllAsync(PagedAndSortedResultRequestDto input);
    }
}
