using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persistence
{
    [Table("ATGN_ErrorReport_TX")]
    public class ErrorReport : AuditableEntity
    {
        public long OID { get; set; }
        public DateTime TransactionDateTime { get; set; }
        [MaxLength(50)]
        public string PatientNRIC { get; set; }
        public string Procedures { get; set; }
        public string VisitType { get; set; }
        [MaxLength(100)]
        public string Polyclinic { get; set; }
        public string Exception { get; set; }
        [MaxLength(450)]
        public string ErrorCorrelationId { get; set; }
        public string AdditionalInfo { get; set; }
        [MaxLength(450)]
        public string TransactionId{ get; set; }

    }
}
