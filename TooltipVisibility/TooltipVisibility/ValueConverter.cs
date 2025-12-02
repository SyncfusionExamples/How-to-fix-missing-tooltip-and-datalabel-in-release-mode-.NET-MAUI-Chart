using System;
using System.Globalization;
using Microsoft.Maui.Controls;

#if IOS
using Foundation;
#endif
using TooltipVisibility.ViewModels;
using TooltipVisibility.Models;

namespace TooltipVisibility.Converters
{
#if IOS
    [Preserve(AllMembers = true)]
#endif
    public class ValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is WeekPlan model)
            {
                switch (parameter?.ToString())
                {
                    case "Planned":
                        return model.Planned;
                }
            }
            
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => value;
    }
}
