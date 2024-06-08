using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.Employee.Dto;
using HCA.Shift.Dto;
using HCA.TechnicianType.Dto;
using HCA.TechnicinaType;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.TechnicianType
{
    public class TechnicianTypeAppService : AsyncCrudAppService<TechnicianTypes, TechnicianTypeDto, int, PagedAndSortedResultRequestDto, TechnicianTypeCreateOrUpdateDto, TechnicianTypeCreateOrUpdateDto>
    {
        public TechnicianTypeAppService(IRepository<TechnicianTypes, int> repository) : base(repository)
        {
        }
        public override async Task<PagedResultDto<TechnicianTypeDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = Repository.GetAllIncluding(shift => shift.Technicians);

            var totalCount = await query.CountAsync();

            // Apply sorting and paging here as needed
            var technicianTypes = await query.ToListAsync();

            var technicianTypesDtos = ObjectMapper.Map<List<TechnicianTypeDto>>(technicianTypes);



            return new PagedResultDto<TechnicianTypeDto>(totalCount, technicianTypesDtos);
        }
    }
}
