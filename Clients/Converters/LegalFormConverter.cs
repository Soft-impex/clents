using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace Clients.Converters
{
    class LegalFormConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int legalFormInt = (int)value;
            return EnumHelper.GetEnumValue<LegalFromEnum>(legalFormInt).Description();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            MessageBox.Show(value.ToString());
            return (int)EnumHelper.GetEnumValue<LegalFromEnum>((string)value);
        }
    }
}
