using System.Collections.Generic;
using RS.AbpQuick.Roles.Dto;

namespace RS.AbpQuick.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
