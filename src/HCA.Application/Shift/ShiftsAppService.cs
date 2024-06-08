using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using HCA.Shift.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCA.Shift
{
    public class ShiftsAppService : AsyncCrudAppService<Shifts, ShiftsDto, int, PagedAndSortedResultRequestDto, ShiftsCreateOrUpdateDto, ShiftsCreateOrUpdateDto>
    {
        public ShiftsAppService(IRepository<Shifts, int> repository)
            : base(repository)
        {
        }

        public override async Task<PagedResultDto<ShiftsDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var query = Repository.GetAllIncluding(shift => shift.Technicians);

            var totalCount = await query.CountAsync();

            // Apply sorting and paging here as needed
            var shifts = await query.ToListAsync();

            var shiftsDtos = ObjectMapper.Map<List<ShiftsDto>>(shifts);

            // Adding the count of technicians to each DTO
            foreach (var shiftDto in shiftsDtos)
            {
                shiftDto.TechnicianCount = shifts.FirstOrDefault(s => s.Id == shiftDto.Id)?.Technicians?.Count ?? 0;
            }

            return new PagedResultDto<ShiftsDto>(totalCount, shiftsDtos);
        }
    }
}
