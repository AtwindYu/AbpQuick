using Abp.Localization.Dictionaries.Xml;
using Abp.Localization.Sources;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero;

namespace RS.School
{

    [DependsOn(typeof(AbpZeroCoreModule))]
    public class SchoolDomainModule:AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.Sources.Extensions.Add(
                new LocalizationSourceExtensionInfo(
                    AbpZeroConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SchoolDomainModule).GetAssembly(), "Abp.Zero.Localization.SourceExt"
                    )
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolDomainModule).GetAssembly());
        }
    }
}
