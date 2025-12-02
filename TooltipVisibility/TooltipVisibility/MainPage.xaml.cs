using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Globalization;
using Microsoft.Maui.Controls;

#if IOS
using Foundation;
#endif

namespace TooltipVisibility;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
}