using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FutureAppointment
    {
        /// <summary>
        /// Unique ID of the appointment book. Of type CSN
        /// </summary>
        public string ApptUniqueID { get; set; }

        /// <summary>
        /// Time of the appointment. Format is 24hh:mm:ss
        /// </summary>
        public string ApptTime { get; set; }

        /// <summary>
        /// Date of the appointment. Format is YYYY-MM-DD
        /// </summary>
        public string ApptDate { get; set; }

        /// <summary>
        /// Resource room booked to the appointments
        /// </summary>
        public string ResourceApptLocation { get; set; }

        /// <summary>
        /// Provider booked to the appointments
        /// </summary>
        public string ProviderPerson { get; set; }

        /// <summary>
        /// Name of the visit type
        /// </summary>
        public string VisitType { get; set; }

        /// <summary>
        /// Unique ID of the visit type
        /// </summary>
        public string VisitTypeID { get; set; }

        /// <summary>
        /// Length of the duration to the appointment
        /// </summary>
        public string ApptDuration { get; set; }

        /// <summary>
        /// Appointments remarks if any
        /// </summary>
        public string ApptNote { get; set; }

        /// <summary>
        /// EPIC department ID
        /// </summary>
        public string DepartmentCode { get; set; }

        /// <summary>
        /// ID of the resource room booked for the appointment
        /// </summary>
        public string ApptLocationID { get; set; }

        /// <summary>
        /// Visit type external name
        /// </summary>
        public string VisitTypeShortName { get; set; }

        /// <summary>
        /// Error description if its available
        /// </summary>
        public string ErrorCode { get; set; }

        ///// <summary>
        ///// Teamlet the patient is assigned to
        ///// </summary>
        //public string Teamlet { get; set; }

        ///// <summary>
        ///// Name of polyclinic 
        ///// </summary>
        //public string DepartmentName { get; set; }
    }
}
