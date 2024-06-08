using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.CatalogServices;
using HCA.CatelogServices.RepairServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.RepairServices
{
    public class RepairServiceAppService : AsyncCrudAppService<RepairService, RepairServiceDto, int, PagedAndSortedResultRequestDto, RepairServiceCreateOrUpdateDto, RepairServiceCreateOrUpdateDto>
    {
        public RepairServiceAppService(IRepository<RepairService, int> repository) : base(repository)
        {
        }
    }
}
