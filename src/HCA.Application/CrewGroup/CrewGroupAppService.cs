using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.CrewGroup.Dto;
using HCA.Employee;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCA.CrewGroup
{
    public class CrewGroupAppService : AsyncCrudAppService<CrewGroups, CrewGroupDto, int, PagedAndSortedResultRequestDto, CrewGroupCreateOrUpdateDto, CrewGroupCreateOrUpdateDto>
    {
        private readonly IRepository<Technician, int> _technicianRepository; // Assuming Technician entity and repository exist

        public CrewGroupAppService(
            IRepository<CrewGroups, int> repository,
            IRepository<Technician, int> technicianRepository
        ) : base(repository)
        {
            _technicianRepository = technicianRepository;
        }

        // Method to get all CrewGroups with their Technicians
        public async Task<List<CrewGroupDto>> GetAllCrewGroupsWithTechnicians()
        {
            var crewGroups = await Repository.GetAllIncluding(cg => cg.Technicians).ToListAsync();

            return ObjectMapper.Map<List<CrewGroupDto>>(crewGroups);
        }
    }
}
