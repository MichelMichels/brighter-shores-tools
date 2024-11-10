using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace BrighterShoresTools.Frontend.Converters;

public class EmptyListToVisibleConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not IEnumerable<object> enumerable)
        {
            return Visibility.Collapsed;
        }

        return !enumerable.Any() ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
