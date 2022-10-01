using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persistence
{
    [Table("ATGN_AuditTrail_TX")]
    public class AuditTrail : AuditableEntity
    {
        [Key]
        public long OID { get; set; }
        public DateTime AuditDateTime { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
        public string Value { get; set; }
        public string ClientIP { get; set; }
    }
}
