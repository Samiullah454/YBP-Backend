using System.Threading.Tasks;
using HCA.Configuration.Dto;

namespace HCA.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
