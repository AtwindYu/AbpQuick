using Abp.AutoMapper;
using RS.AbpQuick.Sessions.Dto;

namespace RS.AbpQuick.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
