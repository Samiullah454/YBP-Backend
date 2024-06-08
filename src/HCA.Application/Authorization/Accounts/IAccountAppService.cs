using System.Threading.Tasks;
using Abp.Application.Services;
using HCA.Authorization.Accounts.Dto;

namespace HCA.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);
        Task<int> IsTenantAvailableGetId(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
