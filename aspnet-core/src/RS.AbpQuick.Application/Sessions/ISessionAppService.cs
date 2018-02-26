using System.Threading.Tasks;
using Abp.Application.Services;
using RS.AbpQuick.Sessions.Dto;

namespace RS.AbpQuick.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
