using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using RS.Configuration;
using RS.School.DependencyInjection;

namespace RS.School
{
    [DependsOn(typeof(SchoolEntityFrameworkModule))]
    public class SchoolMigratorModule : AbpModule
    {

        private readonly IConfigurationRoot _appConfiguration;

        public SchoolMigratorModule(SchoolEntityFrameworkModule projectNameEntityFrameworkModule)
        {
            //projectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfiguration.Get(
                typeof(SchoolMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
               SchoolConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus),
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }


    }
}
