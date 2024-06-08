using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Json;
using HCA.Employee;
using HCA.Employee.Dto;
using HCA.Job.Checklists.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCA.Jobs
{
    public class JobAppService : AsyncCrudAppService<Job, JobDto, int, PagedAndSortedResultRequestDto, JobCreateOrUpdateDto, JobCreateOrUpdateDto>
    {
        private readonly IRepository<JobChecklist, int> _jobChecklistRepository;
        private readonly IRepository<TechnicianJob, int> _technicianJobRepository;
        private readonly IRepository<JobService, int> _jobserviceRepository;
        private readonly IRepository<Technician, int> _technicianRepository;


        public JobAppService(IRepository<Job, int> repository,
                             IRepository<JobChecklist, int> jobChecklistRepository,
                             IRepository<TechnicianJob, int> technicianJobRepository,
                             IRepository<JobService, int> jobserviceRepository,
                             IRepository<Technician ,int> techniocianRepository)
                             
        : base(repository)
        {
            _jobChecklistRepository = jobChecklistRepository;
            _technicianJobRepository = technicianJobRepository;
            _jobserviceRepository = jobserviceRepository;
            _technicianRepository = techniocianRepository;
        }

        public override async Task<JobDto> CreateAsync(JobCreateOrUpdateDto input)
        {
            var job = ObjectMapper.Map<Job>(input);
            var createdJob = await Repository.InsertAsync(job);

            //if (createdJob != null && createdJob.Id > 0)
            //{
            //    if (input.JobChecklist != null && input.JobChecklist.Any())
            //    {
            //        foreach (var checklistDto in input.JobChecklist)
            //        {
            //            var jobChecklist = new JobChecklist
            //            {
            //                JobId = createdJob.Id,
            //                ChecklistId = checklistDto.ChecklistId
            //            };
            //            await _jobChecklistRepository.InsertAsync(jobChecklist);
            //        }
            //    }

            //if (input.TechnicianIds != null && input.TechnicianIds.Any())
            //{
            //    foreach (var TechnicianId in input.TechnicianIds)
            //    {
            //        var technicianJob = new TechnicianJob
            //        {
            //            JobId = createdJob.Id,
            //            TechnicianId = TechnicianId
            //        };
            //        await _technicianJobRepository.InsertAsync(technicianJob);
            //    }
            //}

            return ObjectMapper.Map<JobDto>(createdJob);
        }
        public override async Task<JobDto> UpdateAsync(JobCreateOrUpdateDto input)
        {
            var job = await Repository.GetAsync(input.Id);
            ObjectMapper.Map(input, job);


    

            foreach (var checklistToRemove in input.JobChecklistIds)
            {
                await _jobChecklistRepository.DeleteAsync(checklistToRemove);
            }

            foreach (var technicianjobToRemove in input.TechnicianJobIds)
            {
                await _technicianJobRepository.DeleteAsync(technicianjobToRemove);
            }
            foreach (var jobserviceToRemove in input.JobServiceIds)
            {
                await _jobserviceRepository.DeleteAsync(jobserviceToRemove);
            }
            await Repository.UpdateAsync(job);

            return MapToEntityDto(job);
        }



        public override async Task<PagedResultDto<JobDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            var jobsQuery = Repository.GetAllIncluding(
                x => x.JobChecklist,
                x => x.TechnicianJob,
                x =>  x.JobType,
                x =>x.Customer,
                x  =>x.JobService
            ).OrderByDescending(x => x.CreationTime);

            var totalCount = await jobsQuery.CountAsync();

            var jobs = await jobsQuery
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .ToListAsync();

            var jobDtos = jobs.Select(job => ObjectMapper.Map<JobDto>(job)).ToList();

            return new PagedResultDto<JobDto>(totalCount, jobDtos);
        }




    }
}
