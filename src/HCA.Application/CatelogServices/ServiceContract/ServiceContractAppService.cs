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
    public class ServiceContractAppService : AsyncCrudAppService<ServiceContracts, ServiceContractDto, int, PagedAndSortedResultRequestDto, ServiceContractCreateOrUpdateDto, ServiceContractCreateOrUpdateDto>
    {
        public ServiceContractAppService(IRepository<ServiceContracts, int> repository) : base(repository)
        {
        }
    }
}
