using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HC.RetailClient.Configuration.Dto;

namespace HC.RetailClient.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RetailClientAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
