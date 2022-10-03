using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment
    {
        public string PatientName { get; set; }
        public string Date { get; set; }
        public string VisitTypeName { get; set; }
        public string[] AppointmentNotes { get; set; }
        public string AppointmentStartTime { get; set; }
        public string AppointmentDuration { get; set; }
        public string AppointmentStatus { get; set; }
        public PatientId[] PatientIDs { get; set; }
        public ContactId[] ContactIDs { get; set; }
        public VisitTypeId[] VisitTypeIDs { get; set; }
        public Provider[] Providers { get; set; }
        public ExtraItem[] ExtraItems { get; set; }
        public ExtraExtension[] ExtraExtensions { get; set; }
    }
}
