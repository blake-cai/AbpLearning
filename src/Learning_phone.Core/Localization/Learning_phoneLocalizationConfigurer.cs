using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Learning_phone.Localization
{
    public static class Learning_phoneLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Learning_phoneConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Learning_phoneLocalizationConfigurer).GetAssembly(),
                        "Learning_phone.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
