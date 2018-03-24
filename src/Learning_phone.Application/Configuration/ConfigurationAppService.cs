using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Learning_phone.Configuration.Dto;

namespace Learning_phone.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Learning_phoneAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
