using System.Collections.ObjectModel;
#if IOS
using Foundation;
#endif

namespace TooltipVisibility.Models
{
#if IOS
    [Preserve(AllMembers = true)]
#endif
    public class WeekPlan
    {
        public int WeekNumber { get; set; }
        public double Planned { get; set; }
    }
}