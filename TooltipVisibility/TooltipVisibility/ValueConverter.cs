using System;
using System.Globalization;
using Microsoft.Maui.Controls;
using TooltipVisibility.ViewModels;
using TooltipVisibility.Models;

namespace TooltipVisibility.Converters
{
    public class ValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is WeekPlan weekPlan ? weekPlan.Planned : value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => value;
    }
}
