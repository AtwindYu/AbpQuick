using System;
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


            #region 将缓存设定配置在Application层中，则后面引用它的Core及其它API和MVC都可以使用这种设定

            //缓存的过期时间默认是60分钟。
            //它是变化的。如果你在60分钟内没有使用该缓存，该缓存会被自动的移除。
            //如果你想改变所有的缓存或者指定的缓存来的默认过期时间，你可以这样做，实现如下：

            //对所有缓存的配置
            Configuration.Caching.ConfigureAll(cache =>
            {
                cache.DefaultSlidingExpireTime = TimeSpan.FromMinutes(10);//5分钟不用就过期
                cache.DefaultAbsoluteExpireTime = TimeSpan.FromMinutes(60);//60分钟不管用不用，肯定过期。
            });

            ////对指定缓存的配置
            //Configuration.Caching.Configure("MyCache", cache =>
            //{
            //    cache.DefaultSlidingExpireTime = TimeSpan.FromHours(8);
            //});

            //这些配置将会在首次创建缓存的时候生效。配置不仅仅局限于DefaultSlidingExpireTime，你可以利用ICache接口中的属性获取方法来自由的配置并且初始化它们。

            #endregion
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
