using System.Collections.Generic;
using LPDemo.Roles.Dto;
using LPDemo.Users.Dto;

namespace LPDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}