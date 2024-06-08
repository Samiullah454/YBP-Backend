using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HCA.Configuration.Dto;

namespace HCA.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HCAAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
