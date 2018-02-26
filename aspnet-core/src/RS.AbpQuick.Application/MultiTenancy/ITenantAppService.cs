using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RS.AbpQuick.MultiTenancy.Dto;

namespace RS.AbpQuick.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
