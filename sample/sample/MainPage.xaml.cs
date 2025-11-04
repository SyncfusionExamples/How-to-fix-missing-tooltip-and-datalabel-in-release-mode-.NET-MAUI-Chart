using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Globalization;
using Microsoft.Maui.Controls;

#if IOS
using Foundation;
#endif

namespace sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class ValueConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is Model model)
            {
                switch (parameter?.ToString())
                {
                    case "Planned":
                        return model.Planned;
                }
            }
            return value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value;
        }
    }

#if IOS
    [Preserve(AllMembers = true)]
#endif
    public class ViewModel
    {
        public ObservableCollection<Model> ChartData { get; set; } = new()
        {
            new Model { WeekNumber = 1, Planned= 3 },
            new Model { WeekNumber = 2, Planned= 5 },
            new Model { WeekNumber = 3, Planned= 2 },
            new Model { WeekNumber = 4, Planned= 5 },
            new Model { WeekNumber = 5, Planned= 7 },
        };
    }

#if IOS
    [Preserve(AllMembers = true)]
#endif
    public class Model
    {
        public double WeekNumber { get; set; }
        public double Planned { get; set; }
    }
}