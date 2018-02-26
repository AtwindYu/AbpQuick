using System.Collections.Generic;
using System.Linq;
using RS.AbpQuick.Roles.Dto;
using RS.AbpQuick.Users.Dto;

namespace RS.AbpQuick.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
