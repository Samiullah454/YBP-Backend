using System.Threading.Tasks;
using Abp.Application.Services;
using HCA.Sessions.Dto;

namespace HCA.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
