using System;
using System.Globalization;
using System.Windows.Data;

namespace Vavatech.Shop.WPFClient.Converters
{
    public class StringsToStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string result = string.Empty;

            foreach (var value in values)
            {
                result += value + " ";
            }

            return result;
            
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
