using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HC.RetailClient.Localization
{
    public static class RetailClientLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RetailClientConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RetailClientLocalizationConfigurer).GetAssembly(),
                        "HC.RetailClient.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
