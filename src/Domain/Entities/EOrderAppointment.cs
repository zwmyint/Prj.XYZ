using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EOrderAppointment
    {
        public string ApptUniqueID { get; set; }
        public string ApptTime { get; set; }
        public string ApptDate { get; set; }
        public string ResourceApptLocation { get; set; }
        public string ProviderId { get; set; }
        public string VisitType { get; set; }
        public string VisitTypeID { get; set; }
        public string ApptDuration { get; set; }
        public string ApptNote { get; set; }
        public string DepartmentCode { get; set; }
        public List<string> OrderUniqueId { get; set; }
        public string ApptLocationID { get; set; }
        public string ErrorCode { get; set; }
        public string BundleID { get; set; }
    }
}
