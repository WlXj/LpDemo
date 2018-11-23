using System.Threading.Tasks;
using Abp.Application.Services;
using LPDemo.Configuration.Dto;

namespace LPDemo.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}