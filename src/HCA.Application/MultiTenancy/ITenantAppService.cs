using Abp.Application.Services;
using HCA.MultiTenancy.Dto;
using System.Collections.Generic;

namespace HCA.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
        
    }
}

