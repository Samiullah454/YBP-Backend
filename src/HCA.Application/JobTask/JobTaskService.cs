using Abp.Application.Services;
using Abp.Domain.Repositories;
using HCA.JobTask.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.JobTask
{
    public class JobTaskService : AsyncCrudAppService<JobTasks, JobTaskDto, int>
    {
        public JobTaskService(IRepository<JobTasks, int> repository) : base(repository)
        {
        }
    }
}