using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.CatalogServices;
using HCA.CatelogServices.WarrantyClaimServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.WarrantyClaimServices
{
    public class WarrantyClaimServiceTypeAppService : AsyncCrudAppService<WarrantyClaimServiceType, WarrantyClaimServiceTypeDto, int, PagedAndSortedResultRequestDto, WarrantyClaimServiceTypeCreateOrUpdateDto, WarrantyClaimServiceTypeCreateOrUpdateDto>
    {
        public WarrantyClaimServiceTypeAppService(IRepository<WarrantyClaimServiceType, int> repository) : base(repository)
        {
        }
    }
}
