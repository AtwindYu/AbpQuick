using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RS.AbpQuick.Localization
{
    public static class AbpQuickLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpQuickConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpQuickLocalizationConfigurer).GetAssembly(),
                        "RS.AbpQuick.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
