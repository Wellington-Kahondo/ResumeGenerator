using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ResumeGenerator.Localization
{
    public static class ResumeGeneratorLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ResumeGeneratorConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ResumeGeneratorLocalizationConfigurer).GetAssembly(),
                        "ResumeGenerator.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
