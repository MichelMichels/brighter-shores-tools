﻿using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace BrighterShoresTools.Frontend.Converters;

public class NotNullToVisibleConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is not null ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
