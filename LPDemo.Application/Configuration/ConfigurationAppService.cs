using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LPDemo.Configuration.Dto;

namespace LPDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LPDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
