using System.Collections.ObjectModel;
using TooltipVisibility.Models;
#if IOS
using Foundation;
#endif

namespace TooltipVisibility.ViewModels
{
    public class ChartViewModel
    {
#if IOS
        [Preserve(AllMembers = true)]
#endif
        public ObservableCollection<WeekPlan> ChartData { get; } = new()
        {
            new WeekPlan { WeekNumber = 1, Planned = 3 },
            new WeekPlan { WeekNumber = 2, Planned = 5 },
            new WeekPlan { WeekNumber = 3, Planned = 2 },
            new WeekPlan { WeekNumber = 4, Planned = 5 },
            new WeekPlan { WeekNumber = 5, Planned = 7 },
        };
    }

}