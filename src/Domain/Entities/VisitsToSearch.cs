using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VisitsToSearch
    {
        public string VisitTypeID { get; set; }
        public string VisitTypeIDType { get; set; }
        public Department[] Departments { get; set; }
        public Id[] Orders { get; set; }
        public List<SchedulePreference> SchedulePreferences { get; set; }
        public List<DateRange> DateRanges { get; set; }
    }
}
