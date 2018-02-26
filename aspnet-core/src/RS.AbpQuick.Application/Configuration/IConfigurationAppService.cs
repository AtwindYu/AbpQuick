using System.Threading.Tasks;
using RS.AbpQuick.Configuration.Dto;

namespace RS.AbpQuick.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
