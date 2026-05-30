using Avalonia.Data.Converters;
using System;
using System.Globalization;
using System.Resources;

namespace ASTEM_DB;

public static class Localization
{
    public static ResourceManager Resources
        = new ResourceManager("ASTEM_DB.Resources.Strings", typeof(Localization).Assembly);
}

public class L10n : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return Localization.Resources.GetString(parameter.ToString(), culture)
               ?? parameter.ToString();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
