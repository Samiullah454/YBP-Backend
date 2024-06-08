using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.CatalogServices;
using HCA.CatelogServices.Part.Dto;
using HCA.CatelogServices.Parts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.Parts
{
    public class PartTypeAppService : AsyncCrudAppService<PartType, PartTypeDto, int, PagedAndSortedResultRequestDto, PartTypeCreateOrUpdateDto, PartTypeCreateOrUpdateDto>
    {
        public PartTypeAppService(IRepository<CatalogServices.PartType, int> repository) : base(repository)
        {
        }
    }
}
