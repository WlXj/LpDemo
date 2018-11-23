using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LPDemo.MultiTenancy.Dto;

namespace LPDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
