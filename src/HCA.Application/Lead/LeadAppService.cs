using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Lead
{
    public class LeadAppService : AsyncCrudAppService<Leads.Lead, LeadDto, int, PagedAndSortedResultRequestDto, LeadDto>
    {
        public LeadAppService(IRepository<Leads.Lead, int> repository) : base(repository)
        {
        }
    }
}