using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RS.AbpQuick.Roles.Dto;

namespace RS.AbpQuick.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
