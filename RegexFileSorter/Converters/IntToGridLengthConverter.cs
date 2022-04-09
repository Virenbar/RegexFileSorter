using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace RegexFileSorter.Converters
{
    internal class IntToGridLengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => new GridLength(Math.Min(10, Math.Max(1, (int)value)), GridUnitType.Star);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}