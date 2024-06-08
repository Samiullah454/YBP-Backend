using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using HCA.Employee.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;
using Abp.UI;
using Abp.Domain.Entities;
using HCA.Jobs;

namespace HCA.Employee
{
    public class TechnicianAppService : AsyncCrudAppService<Technician, TechnicianDto, int, PagedAndSortedResultRequestDto, TechnicianCreateOrUpdateDto, TechnicianCreateOrUpdateDto>
    {
        private readonly IRepository<TechnicianServices, int> _technicianServicetRepository;
        public TechnicianAppService(
            IRepository<Technician, int> repository,
             IRepository<TechnicianServices, int> technicianServicetRepository)
           
            : base(repository)
        {
            _technicianServicetRepository = technicianServicetRepository;
        }
        public override async Task<TechnicianDto> GetAsync(EntityDto<int> input)
        {
            // Fetch the entity with included TechnicianServices
            var entity = await Repository.GetAllIncluding(t => t.Shifts, t => t.CrewGroups, t => t.ServiceAreas, t => t.TechnicianTypes, t => t.TechnicianServices)
                .FirstOrDefaultAsync(t => t.Id == input.Id);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Technician), input.Id);
            }

            return MapToEntityDto(entity);
        }

        public override async Task<PagedResultDto<TechnicianDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            // Include the Shifts and CrewGroups data when retrieving technicians
            var query = Repository.GetAllIncluding(t => t.Shifts, t => t.CrewGroups, t => t.ServiceAreas, t => t.TechnicianTypes ,t => t.TechnicianServices);

            var totalCount = await query.CountAsync();

            // Apply sorting, paging
            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);

            var entities = await query.ToListAsync();

            // Map to DTOs
            var dtos = ObjectMapper.Map<List<TechnicianDto>>(entities);

            return new PagedResultDto<TechnicianDto>(totalCount, dtos);
        }
        public override async Task<TechnicianDto> UpdateAsync(TechnicianCreateOrUpdateDto input)
        {
            // Fetch the existing technician
            var existingTechnician = await GetEntityByIdAsync(input.Id);
            ObjectMapper.Map(input, existingTechnician);
            if (existingTechnician == null)
            {
                throw new UserFriendlyException("The technician to be updated could not be found.");
            }

            foreach (var idsToRemove in input.IdsToDel)
            {
                await _technicianServicetRepository.DeleteAsync(idsToRemove);
            }

            // Save the changes
            await Repository.UpdateAsync(existingTechnician);

            // Map the updated entity back to DTO and return
            return MapToEntityDto(existingTechnician);
        }



        [HttpPut]
        public async Task AssignTechniciansToShift(AssignTechnicianDto input)
        {
            var validCallers = new List<string> { "shift", "crewgroup", "servicearea", "types" };

            if (!validCallers.Contains(input.Caller))
            {
                throw new ArgumentException("Invalid caller type.");
            }

            // Fetch all technicians based on the specified caller type
            var currentTechnicians = await FetchTechniciansByCallerType(input);

            // Create a HashSet for performance
            var technicianIdsSet = new HashSet<int>(input.TechniciansId);

            // Update existing technicians
            foreach (var technician in currentTechnicians)
            {
                if (technicianIdsSet.Contains(technician.Id))
                {
                    // Update if the technician is in the new list
                    UpdateTechnicianForCallerType(technician, input);
                    technicianIdsSet.Remove(technician.Id); // Remove to avoid re-adding later
                }
                else
                {
                    // Remove the technician from the specified caller type
                    RemoveTechnicianForCallerType(technician, input);
                }
                await Repository.UpdateAsync(technician);
            }

            // Add new technicians
            await AddNewTechniciansForCallerType(technicianIdsSet, input);

            await CurrentUnitOfWork.SaveChangesAsync();
        }

        private async Task<List<Technician>> FetchTechniciansByCallerType(AssignTechnicianDto input)
        {
            return input.Caller switch
            {
                "shift" => await Repository.GetAllListAsync(t => t.ShiftId == input.Id),
                "crewgroup" => await Repository.GetAllListAsync(t => t.CrewGroupId == input.Id),
                "servicearea" => await Repository.GetAllListAsync(t => t.ServiceAreasId == input.Id),
                "types" => await Repository.GetAllListAsync(t => t.TechnicianTypeId == input.Id),
                _ => throw new ArgumentException("Invalid caller type."),
            };
        }

        private void UpdateTechnicianForCallerType(Technician technician, AssignTechnicianDto input)
        {
            technician.ShiftId = input.Caller == "shift" ? input.Id : technician.ShiftId;
            technician.CrewGroupId = input.Caller == "crewgroup" ? input.Id : technician.CrewGroupId;
            // Add logic for new caller types here
            technician.ServiceAreasId = input.Caller == "servicearea" ? input.Id : technician.ServiceAreasId;
            technician.TechnicianTypeId = input.Caller == "types" ? input.Id : technician.TechnicianTypeId;
        }

        private void RemoveTechnicianForCallerType(Technician technician, AssignTechnicianDto input)
        {
            technician.ShiftId = input.Caller == "shift" ? null : technician.ShiftId;
            technician.CrewGroupId = input.Caller == "crewgroup" ? null : technician.CrewGroupId;
            // Add logic for new caller types here
            technician.ServiceAreasId = input.Caller == "servicearea" ? null : technician.ServiceAreasId;
            technician.TechnicianTypeId = input.Caller == "types" ? null : technician.TechnicianTypeId;
        }

        private async Task AddNewTechniciansForCallerType(HashSet<int> technicianIdsSet, AssignTechnicianDto input)
        {
            foreach (var technicianId in technicianIdsSet)
            {
                var newTechnician = await Repository.FirstOrDefaultAsync(technicianId); // Assuming FirstOrDefaultAsync fetches by ID
                if (newTechnician != null)
                {
                    UpdateTechnicianForCallerType(newTechnician, input);
                    await Repository.UpdateAsync(newTechnician);
                }
            }
        }




    }
}
