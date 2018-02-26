using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RS.AbpQuick.Configuration.Dto;

namespace RS.AbpQuick.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpQuickAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
