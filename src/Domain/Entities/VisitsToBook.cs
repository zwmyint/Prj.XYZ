using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VisitsToBook
    {
        public string[] AppointmentNotes { get; set; }
        public string BlockOverrule { get; set; }
        public string[] Blocks { get; set; }
        public string Date { get; set; }
        public string ExternalVisitIdentifier { get; set; }
        public string[] ExtraData { get; set; }
        public string FromPanelID { get; set; }
        public string FromPanelIDType { get; set; }
        public Id[] Orders { get; set; }
        public string PanelLinkKey { get; set; }
        public Providers[] Providers { get; set; }
        public string ReferralID { get; set; }
        public string ReferralIDType { get; set; }
        public string RescheduledFromContactID { get; set; }
        public string RescheduledFromContactIDType { get; set; }
        public string[] Tags { get; set; }
        public string VisitTypeID { get; set; }
        public string VisitTypeIDType { get; set; }
        public string WaitListContactID { get; set; }
        public string WaitListContactIDType { get; set; }
    }
}
