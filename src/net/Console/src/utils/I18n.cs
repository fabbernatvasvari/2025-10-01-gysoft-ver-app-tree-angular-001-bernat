using System.Globalization;
using System.Resources;

namespace MyApp.Console.src.utils;

internal static class I18n
{
    private static readonly ResourceManager resourceManager =
        new("MyApp.Console.src.resources.Strings", typeof(I18n).Assembly);

    public static string T(string key, params object[] args)
    {
        var value = resourceManager.GetString(
            key,
            CultureInfo.CurrentUICulture
        ) ?? $"!{key}!";

        return args.Length > 0
            ? string.Format(value, args)
            : value;
    }
}
