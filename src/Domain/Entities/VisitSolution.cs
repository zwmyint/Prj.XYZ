using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VisitSolution
    {
        public string Date { get; set; }
        public string VisitTypeName { get; set; }
        public string PartialSolutionError { get; set; }
        public string PanelLinkKey { get; set; }
        public VisitTypeId[] VisitTypeIDs { get; set; }
        public Provider[] Providers { get; set; }
        public ScheduleWarning[] ScheduleWarnings { get; set; }
        public string[] FromPanelIDs { get; set; }
        public string[] ExtraData { get; set; }
    }
}
