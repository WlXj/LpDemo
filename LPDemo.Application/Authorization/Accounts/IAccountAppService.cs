using System.Threading.Tasks;
using Abp.Application.Services;
using LPDemo.Authorization.Accounts.Dto;

namespace LPDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
