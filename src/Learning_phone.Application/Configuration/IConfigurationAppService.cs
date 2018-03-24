using System.Threading.Tasks;
using Learning_phone.Configuration.Dto;

namespace Learning_phone.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
