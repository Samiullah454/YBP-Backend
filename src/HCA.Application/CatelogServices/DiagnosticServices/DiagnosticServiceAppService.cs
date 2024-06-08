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
    public class DiagnosticServiceAppService : AsyncCrudAppService<DiagnosticService, DiagnosticServiceDto, int, PagedAndSortedResultRequestDto, DiagnosticServiceCreateOrUpdateDto, DiagnosticServiceCreateOrUpdateDto>
    {
        public DiagnosticServiceAppService(IRepository<DiagnosticService, int> repository) : base(repository)
        {
        }

    }
}
