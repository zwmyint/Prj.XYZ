using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Visit
    {
        public string[] PatientInstructions { get; set; }
        public string[] DepartmentDirections { get; set; }
        public string CoverageDisplayName { get; set; }
        public string CoverageCopay { get; set; }
        public string Date { get; set; }
        public string VisitTypeName { get; set; }
        public bool Confirmed { get; set; }
        public ContactId[] ContactIDs { get; set; }
        public VisitTypeId[] VisitTypeIDs { get; set; }
        public Provider[] Providers { get; set; }
        public Warning[] Warnings { get; set; }
        public string[] ExtraData { get; set; }
    }
}
