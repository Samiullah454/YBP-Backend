using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HCA.CatalogServices;
using HCA.CatelogServices.DiagnosticServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.CatelogServices.DiagnosticServices
{
    public class DiagnosticTypeAppService : AsyncCrudAppService<DiagnosticType, DiagnosticTypeDto, int, PagedAndSortedResultRequestDto, DiagnosticTypeCreateOrUpdateDto, DiagnosticTypeCreateOrUpdateDto>
    {
        public DiagnosticTypeAppService(IRepository<DiagnosticType, int> repository) : base(repository)
        {
        }
    }
}
