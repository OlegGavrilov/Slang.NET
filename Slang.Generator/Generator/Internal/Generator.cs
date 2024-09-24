using System.Globalization;
using Slang.Generator.Generator.Entities;
using Slang.Generator.NodesData;

namespace Slang.Generator.Generator;

internal static partial class Generator
{
    public static BuildResult Generate(
        GenerateConfig config,
        List<I18NData> translations)
    {
        string header = GenerateHeader(config, translations);

        var list = translations
            .ToDictionary<I18NData, CultureInfo, string>(
                translation => translation.Locale,
                translation => GenerateTranslations(config, translation));

        return new BuildResult(
            Header: header,
            Translations: list
        );
    }
}