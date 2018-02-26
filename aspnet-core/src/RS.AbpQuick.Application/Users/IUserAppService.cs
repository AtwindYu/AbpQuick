using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RS.AbpQuick.Roles.Dto;
using RS.AbpQuick.Users.Dto;

namespace RS.AbpQuick.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
