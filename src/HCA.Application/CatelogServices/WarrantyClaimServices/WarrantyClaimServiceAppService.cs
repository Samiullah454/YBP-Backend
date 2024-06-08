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
    public class WarrantyClaimServiceAppService : AsyncCrudAppService<WarrantyClaimService, WarrantyClaimServiceDto, int, PagedAndSortedResultRequestDto, WarrantyClaimServiceCreateOrUpdateDto, WarrantyClaimServiceCreateOrUpdateDto>
    {
        public WarrantyClaimServiceAppService(IRepository<WarrantyClaimService, int> repository) : base(repository)
        {
        }
    }
}
