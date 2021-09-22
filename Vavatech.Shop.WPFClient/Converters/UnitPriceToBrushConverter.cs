using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Vavatech.Shop.WPFClient.Converters
{

    public class UnitPriceToBrushConverter : IValueConverter
    {
        private readonly Brush brush1;
        private readonly Brush brush2;

        public UnitPriceToBrushConverter()
        {
            brush1 = new SolidColorBrush(Colors.Red);
            brush2 = new SolidColorBrush(Colors.Black);
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal unitPrice = (decimal)value;

            if (unitPrice > 500)
            {
                return brush1;
            }
            else
            {
                return brush2;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
