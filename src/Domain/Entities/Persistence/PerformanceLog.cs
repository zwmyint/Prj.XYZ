using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persistence
{
    [Table("ATGN_PerfLog_TX")]
    public class PerformanceLog : AuditableEntity
    {
        [Key]
        public long OID { get; set; }
        [MaxLength(450)]
        public string TransactionId { get; set; }
        [MaxLength(1000)]
        public string MethodName { get; set; }
        
        public long ElapsedMilliseconds { get; set; }
        [MaxLength(100)]
        public string Polyclinic { get; set; }
    }
}
