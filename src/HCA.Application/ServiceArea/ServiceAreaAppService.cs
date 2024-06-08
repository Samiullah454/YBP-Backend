using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.ServiceArea.Dto;
using HCA.Shift.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.ServiceArea
{
    public class ServiceAreaAppService : AsyncCrudAppService<ServiceAreas, ServiceAreaDto, int, PagedAndSortedResultRequestDto, ServiceAreaCreateOrUpdateDto, ServiceAreaCreateOrUpdateDto>
    {
        public ServiceAreaAppService(IRepository<ServiceAreas, int> repository) : base(repository)
        {
        }
        public override async Task<PagedResultDto<ServiceAreaDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = Repository.GetAllIncluding(ServiceArea => ServiceArea.Technicians);

            var totalCount = await query.CountAsync();

            // Apply sorting and paging here as needed
            var serviceAreas = await query.ToListAsync();

            var serviceareaDtos = ObjectMapper.Map<List<ServiceAreaDto>>(serviceAreas);

            // Adding the count of technicians to each DTO
   

            return new PagedResultDto<ServiceAreaDto>(totalCount, serviceareaDtos);
        }
    }
}
