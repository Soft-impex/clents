using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Clients.Models;

namespace Clients.Converters
{
    class OrderStateColorSelectedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            OrderStateEnum orderState = (OrderStateEnum)value;

            switch (orderState)
            {
                case OrderStateEnum.Complite:
                    return new LinearGradientBrush(
                Color.FromRgb(115, 223, 130), Color.FromRgb(115, 223, 110), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case OrderStateEnum.Work:
                    return new LinearGradientBrush(
                Color.FromRgb(225, 224, 132), Color.FromRgb(225, 224, 110), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case OrderStateEnum.New:
                    return new LinearGradientBrush(
                Color.FromRgb(129, 181, 229), Color.FromRgb(129, 181, 210), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case OrderStateEnum.Canceled:
                    return new LinearGradientBrush(
                Color.FromRgb(210, 210, 210), Color.FromRgb(200, 200, 200), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                default:
                    return new LinearGradientBrush(
                Color.FromRgb(255, 255, 255), Color.FromRgb(240, 240, 240), new Point(0.5, 0), new Point(0.5, 1));
                    break;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
