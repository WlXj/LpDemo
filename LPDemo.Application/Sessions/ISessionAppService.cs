using System.Threading.Tasks;
using Abp.Application.Services;
using LPDemo.Sessions.Dto;

namespace LPDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
