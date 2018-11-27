using System.Threading.Tasks;
using HC.RetailClient.Configuration.Dto;

namespace HC.RetailClient.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
