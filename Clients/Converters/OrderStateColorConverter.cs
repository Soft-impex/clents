using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Threading;
using Clients.Models;

namespace Clients.Converters
{
    class OrderStateColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            OrderStateEnum orderState = (OrderStateEnum)value;

            switch (orderState)
            {
                case OrderStateEnum.Complite:
                    return new LinearGradientBrush(
                Color.FromRgb(134, 255, 151), Color.FromRgb(118, 254, 137), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case OrderStateEnum.Work:
                    return new LinearGradientBrush(
                Color.FromRgb(255, 254, 158), Color.FromRgb(255, 254, 137), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case OrderStateEnum.New:
                    return new LinearGradientBrush(
                Color.FromRgb(161, 208, 252), Color.FromRgb(161, 208, 230), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                case OrderStateEnum.Canceled:
                    return new LinearGradientBrush(
                Color.FromRgb(231, 231, 231), Color.FromRgb(220, 220, 220), new Point(0.5, 0), new Point(0.5, 1));
                    break;
                default:
                    return new LinearGradientBrush(
                Color.FromRgb(255, 255, 255), Color.FromRgb(255, 255, 255), new Point(0.5, 0), new Point(0.5, 1));
                    break;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
