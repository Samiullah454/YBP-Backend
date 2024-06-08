using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.CatalogServices;
using HCA.CatelogServices.ServiceContract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.ServiceContract
{
    public class ServiceContractTypeAppService : AsyncCrudAppService<ServiceContractType, ServiceContractTypeDto, int, PagedAndSortedResultRequestDto, ServiceContractTypeCreateOrUpdateDto, ServiceContractTypeCreateOrUpdateDto>
    {
        public ServiceContractTypeAppService(IRepository<ServiceContractType, int> repository) : base(repository)
        {
        }
    }
}
