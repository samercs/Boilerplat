using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SamerCs.Configuration.Dto;

namespace SamerCs.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SamerCsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
