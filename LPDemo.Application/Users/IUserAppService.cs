using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LPDemo.Roles.Dto;
using LPDemo.Users.Dto;

namespace LPDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}