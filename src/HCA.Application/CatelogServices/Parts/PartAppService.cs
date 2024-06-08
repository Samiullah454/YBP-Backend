using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.CatalogServices;
using HCA.CatelogServices.Parts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.Parts
{
    public class PartAppService : AsyncCrudAppService<CatalogServices.Part, PartDto, int, PagedAndSortedResultRequestDto, PartCreateOrUpdateDto, PartCreateOrUpdateDto>
    {
        public PartAppService(IRepository<CatalogServices.Part, int> repository) : base(repository)
        {
        }
    }
}
