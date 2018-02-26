using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RS.AbpQuick.Configuration;

namespace RS.AbpQuick.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpQuickWebCoreModule))]
    public class AbpQuickWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpQuickWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpQuickWebHostModule).GetAssembly());
        }
    }
}
