using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.Job.JobTypes.Dto;
using HCA.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Job.JobTypes
{
    public class JobTypeAppService : AsyncCrudAppService<JobType, JobtypeDto, int, PagedAndSortedResultRequestDto, JobtypeCreateorUpdateDto, JobtypeCreateorUpdateDto>
    {
        public JobTypeAppService(IRepository<JobType, int> repository) : base(repository)
        {
        }
    }
}
