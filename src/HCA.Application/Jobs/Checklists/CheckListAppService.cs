using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.Job.Checklists.Dto;
using HCA.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Job.Checklists
{
    public class CheckListAppService : AsyncCrudAppService<Checklist, ChecklistDto, int, PagedAndSortedResultRequestDto, ChecklistCreateOrUpdateDto, ChecklistCreateOrUpdateDto>
    {
        public CheckListAppService(IRepository<Checklist, int> repository) : base(repository)
        {
        }
    }
}
