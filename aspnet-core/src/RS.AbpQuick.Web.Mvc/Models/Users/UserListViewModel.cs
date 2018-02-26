using System.Collections.Generic;
using RS.AbpQuick.Roles.Dto;
using RS.AbpQuick.Users.Dto;

namespace RS.AbpQuick.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
