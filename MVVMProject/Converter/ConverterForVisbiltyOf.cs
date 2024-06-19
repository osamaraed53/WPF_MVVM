using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MVVMProject.Converter;

public class ConverterForVisbiltyOf : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is bool booleaValue && booleaValue ? Visibility.Collapsed : Visibility.Visible;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
