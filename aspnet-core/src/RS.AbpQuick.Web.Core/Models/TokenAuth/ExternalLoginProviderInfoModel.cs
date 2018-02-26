using Abp.AutoMapper;
using RS.AbpQuick.Authentication.External;

namespace RS.AbpQuick.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
