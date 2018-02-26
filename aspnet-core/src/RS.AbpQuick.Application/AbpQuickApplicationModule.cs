using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RS.AbpQuick.Authorization;

namespace RS.AbpQuick
{
    [DependsOn(
        typeof(AbpQuickCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpQuickApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpQuickAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpQuickApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
