using System.Threading.Tasks;
using SamerCs.Configuration.Dto;

namespace SamerCs.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
